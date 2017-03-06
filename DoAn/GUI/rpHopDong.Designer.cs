namespace GUI
{
    partial class rpHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpHopDong));
            this.HopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new GUI.DataSet1();
            this.HopDongTableAdapter = new GUI.DataSet1TableAdapters.HopDongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HopDongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // HopDongBindingSource
            // 
            this.HopDongBindingSource.DataMember = "HopDong";
            this.HopDongBindingSource.DataSource = this.DataSet1;
       
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HopDongTableAdapter
            // 
            this.HopDongTableAdapter.ClearBeforeFill = true;
            // 
            // rpHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 607);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rpHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.rpHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HopDongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HopDongBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.HopDongTableAdapter HopDongTableAdapter;
    }
}