﻿namespace Sol_Minimarket.Presentacion.Reportes_Consolidado
{
    partial class Frm_Rpt_Salida_VentasxProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Reportes_Consolidado = new Sol_Minimarket.Presentacion.Reportes_Consolidado.DataSet_Reportes_Consolidado();
            this.uSPReporteSalidasVentasxProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Reporte_Salidas_VentasxProductosTableAdapter = new Sol_Minimarket.Presentacion.Reportes_Consolidado.DataSet_Reportes_ConsolidadoTableAdapters.USP_Reporte_Salidas_VentasxProductosTableAdapter();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Reportes_Consolidado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteSalidasVentasxProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPReporteSalidasVentasxProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Minimarket.Presentacion.Reportes_Consolidado.Rpt_Salidas_VentasxProductos.rdl" +
    "c";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(966, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Reportes_Consolidado
            // 
            this.dataSet_Reportes_Consolidado.DataSetName = "DataSet_Reportes_Consolidado";
            this.dataSet_Reportes_Consolidado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPReporteSalidasVentasxProductosBindingSource
            // 
            this.uSPReporteSalidasVentasxProductosBindingSource.DataMember = "USP_Reporte_Salidas_VentasxProductos";
            this.uSPReporteSalidasVentasxProductosBindingSource.DataSource = this.dataSet_Reportes_Consolidado;
            // 
            // uSP_Reporte_Salidas_VentasxProductosTableAdapter
            // 
            this.uSP_Reporte_Salidas_VentasxProductosTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(12, 61);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(100, 20);
            this.txt_p2.TabIndex = 5;
            this.txt_p2.Visible = false;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 35);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 4;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Salida_VentasxProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Salida_VentasxProductos";
            this.Text = "Frm_Rpt_Salida_VentasxProductos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Salida_VentasxProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Reportes_Consolidado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteSalidasVentasxProductosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPReporteSalidasVentasxProductosBindingSource;
        private DataSet_Reportes_Consolidado dataSet_Reportes_Consolidado;
        private DataSet_Reportes_ConsolidadoTableAdapters.USP_Reporte_Salidas_VentasxProductosTableAdapter uSP_Reporte_Salidas_VentasxProductosTableAdapter;
        public System.Windows.Forms.TextBox txt_p2;
        public System.Windows.Forms.TextBox txt_p1;
    }
}