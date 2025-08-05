namespace Presentacion2
{
    partial class FrmEmpleados
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
            btnAgregar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnEditar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnEliminar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnLimpiar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnCerrar = new ToolStripButton();
            kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            splitContainer1 = new SplitContainer();
            kryptonHeaderGroup1 = new Krypton.Toolkit.KryptonHeaderGroup();
            kryptonHeaderGroup2 = new Krypton.Toolkit.KryptonHeaderGroup();
            kryptonToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonHeaderGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonHeaderGroup1.Panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonHeaderGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonHeaderGroup2.Panel).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.White;
            btnAgregar.ImageTransparentColor = Color.Magenta;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(53, 22);
            btnAgregar.Text = "Agregar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(41, 22);
            btnEditar.Text = "Editar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.ImageTransparentColor = Color.Magenta;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(54, 22);
            btnEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.ImageTransparentColor = Color.Magenta;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(51, 22);
            btnLimpiar.Text = "Limpiar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.ImageTransparentColor = Color.Magenta;
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(43, 22);
            btnCerrar.Text = "Cerrar";
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.Font = new Font("Segoe UI", 9F);
            kryptonToolStrip1.Items.AddRange(new ToolStripItem[] { btnAgregar, toolStripSeparator1, btnEditar, toolStripSeparator2, btnEliminar, toolStripSeparator3, btnLimpiar, toolStripSeparator4, btnCerrar });
            kryptonToolStrip1.Location = new Point(0, 0);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.Size = new Size(795, 25);
            kryptonToolStrip1.TabIndex = 0;
            kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(kryptonHeaderGroup2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(kryptonHeaderGroup1);
            splitContainer1.Size = new Size(795, 481);
            splitContainer1.SplitterDistance = 265;
            splitContainer1.TabIndex = 1;
            // 
            // kryptonHeaderGroup1
            // 
            kryptonHeaderGroup1.Dock = DockStyle.Fill;
            kryptonHeaderGroup1.Location = new Point(0, 0);
            kryptonHeaderGroup1.Size = new Size(526, 481);
            kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonHeaderGroup1.TabIndex = 0;
            kryptonHeaderGroup1.ValuesPrimary.Description = "Listado de empleados";
            kryptonHeaderGroup1.ValuesPrimary.Heading = "";
            kryptonHeaderGroup1.ValuesPrimary.Image = null;
            kryptonHeaderGroup1.ValuesSecondary.Description = "Registros 0";
            kryptonHeaderGroup1.ValuesSecondary.Heading = "";
            // 
            // kryptonHeaderGroup2
            // 
            kryptonHeaderGroup2.Dock = DockStyle.Fill;
            kryptonHeaderGroup2.Location = new Point(0, 0);
            kryptonHeaderGroup2.Size = new Size(265, 481);
            kryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonHeaderGroup2.TabIndex = 1;
            kryptonHeaderGroup2.ValuesPrimary.Description = "Captura de datos";
            kryptonHeaderGroup2.ValuesPrimary.Heading = "";
            kryptonHeaderGroup2.ValuesPrimary.Image = null;
            kryptonHeaderGroup2.ValuesSecondary.Heading = "";
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 506);
            Controls.Add(splitContainer1);
            Controls.Add(kryptonToolStrip1);
            Name = "FrmEmpleados";
            Text = "FrmEmpleados";
            kryptonToolStrip1.ResumeLayout(false);
            kryptonToolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonHeaderGroup1.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonHeaderGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonHeaderGroup2.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonHeaderGroup2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripButton btnAgregar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnEditar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnEliminar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnLimpiar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnCerrar;
        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private SplitContainer splitContainer1;
        private Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup2;
        private Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
    }
}