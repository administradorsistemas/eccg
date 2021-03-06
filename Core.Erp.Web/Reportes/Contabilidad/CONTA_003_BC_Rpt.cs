﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Bus.Reportes.Contabilidad;
using Core.Erp.Info.Reportes.Contabilidad;
using System.Collections.Generic;
using Core.Erp.Bus.General;
using System.Linq;

namespace Core.Erp.Web.Reportes.Contabilidad
{
    public partial class CONTA_003_BC_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public string usuario { get; set; }
        public string empresa { get; set; }
        public int[] IntArray { get; set; }
        List<CONTA_003_balances_Info> lst_rpt = new List<CONTA_003_balances_Info>();
        tb_sucursal_Bus bus_sucursal = new tb_sucursal_Bus();
        public CONTA_003_BC_Rpt()
        {
            InitializeComponent();
        }

        private void CONTA_003_BC_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            lbl_empresa.Text = empresa;
            lbl_usuario.Text = usuario;
            int IdEmpresa = p_IdEmpresa.Value == null ? 0 : Convert.ToInt32(p_IdEmpresa.Value);
            int IdAnio = p_IdAnio.Value == null ? 0 : Convert.ToInt32(p_IdAnio.Value);
            DateTime fechaIni = p_fechaIni.Value == null ? DateTime.Now : Convert.ToDateTime(p_fechaIni.Value);
            DateTime fechaFin = p_fechaFin.Value == null ? DateTime.Now : Convert.ToDateTime(p_fechaFin.Value);
            string IdUsuario = p_IdUsuario.Value == null ? "" : Convert.ToString(p_IdUsuario.Value);
            int IdNivel = p_IdNivel.Value == null ? 0 : Convert.ToInt32(p_IdNivel.Value);
            bool mostrarSaldo0 = p_mostrarSaldo0.Value == null ? false : Convert.ToBoolean(p_mostrarSaldo0.Value);
            string balance = p_balance.Value == null ? "" : Convert.ToString(p_balance.Value);
            int IdSucursal = string.IsNullOrEmpty(p_IdSucursal.Value.ToString()) ? 0 : Convert.ToInt32(p_IdSucursal.Value);
            bool MostrarSaldoAcumulado = string.IsNullOrEmpty(p_MostrarSaldoAcumulado.Value.ToString()) ? false : Convert.ToBoolean(p_MostrarSaldoAcumulado.Value);
            CONTA_003_balances_Bus bus_rpt = new CONTA_003_balances_Bus();
            string Sucursal = "";

            if (IntArray != null)
            {
                for (int i = 0; i < IntArray.Count(); i++)
                {
                    lst_rpt.AddRange(bus_rpt.get_list(IdEmpresa, IdAnio, fechaIni, fechaFin, IdUsuario, IdNivel, mostrarSaldo0, balance, IntArray[i], MostrarSaldoAcumulado));
                    Sucursal += bus_sucursal.get_info(IdEmpresa, IntArray[i]).Su_Descripcion + (IntArray.Count() - 1 == i ? "" : ", ");
                }
                lst_rpt.ForEach(q => q.Su_Descripcion = Sucursal);
            }

            var ListaReporte = (from q in lst_rpt
                                orderby q.IdCtaCble
                                group q by new
                                {
                                    q.IdCtaCble,
                                    q.pc_Cuenta,
                                    q.Su_Descripcion,
                                    q.EsCuentaMovimiento,
                                    q.IdGrupoCble
                                } 
                                into ListaAgrupada                                
                                select new
                                {
                                    IdCtaCble = ListaAgrupada.Key.IdCtaCble,
                                    pc_Cuenta = ListaAgrupada.Key.pc_Cuenta,
                                    Su_Descripcion = ListaAgrupada.Key.Su_Descripcion,
                                    IdGrupoCble = ListaAgrupada.Key.IdGrupoCble,
                                    EsCuentaMovimiento = ListaAgrupada.Key.EsCuentaMovimiento,
                                    SaldoInicialNaturaleza = ListaAgrupada.Sum(p => p.SaldoInicialNaturaleza),
                                    SaldoDebitosNaturaleza = ListaAgrupada.Sum(p => p.SaldoDebitosNaturaleza),
                                    SaldoCreditosNaturaleza = ListaAgrupada.Sum(p => p.SaldoCreditosNaturaleza),
                                    SaldoFinalNaturaleza = ListaAgrupada.Sum(p => p.SaldoFinalNaturaleza),
                                    SaldoInicial = ListaAgrupada.Sum(p => p.SaldoInicial),
                                    Debitos = ListaAgrupada.Sum(p => p.Debitos),
                                    Creditos = ListaAgrupada.Sum(p => p.Creditos),
                                    SaldoFinal = ListaAgrupada.Sum(p => p.SaldoFinal)
                                }).ToList();
            if (!mostrarSaldo0)
                ListaReporte = ListaReporte.Where(q => Math.Round(q.SaldoFinalNaturaleza, 2, MidpointRounding.AwayFromZero) != 0).ToList();

            this.DataSource = ListaReporte;

            tb_empresa_Bus bus_empresa = new tb_empresa_Bus();
            var emp = bus_empresa.get_info(IdEmpresa);
            if (emp != null)
            {
                lblDireccion.Text = emp.em_direccion;
                lblTelefono.Text = string.IsNullOrEmpty(emp.em_telefonos) ? "" : "Tel. " + emp.em_telefonos;
                if (emp.em_logo != null)
                {
                    ImageConverter obj = new ImageConverter();
                    lbl_imagen.Image = (Image)obj.ConvertFrom(emp.em_logo);
                }
            }
        }
    }
}
