namespace ControlesAvanzados
{
    partial class Archivo
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
            label1 = new Label();
            ListadodeVentarArch = new FlowLayoutPanel();
            SelectorDepartamento = new ListBox();
            comboBoxAnios = new ComboBox();
            comboBoxMeses = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 28);
            label1.Name = "label1";
            label1.Size = new Size(378, 30);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Nuevo Archivo";
            // 
            // ListadodeVentarArch
            // 
            ListadodeVentarArch.AutoScroll = true;
            ListadodeVentarArch.Location = new Point(335, 102);
            ListadodeVentarArch.Name = "ListadodeVentarArch";
            ListadodeVentarArch.Size = new Size(757, 473);
            ListadodeVentarArch.TabIndex = 1;
            // 
            // SelectorDepartamento
            // 
            SelectorDepartamento.FormattingEnabled = true;
            SelectorDepartamento.Location = new Point(26, 133);
            SelectorDepartamento.Name = "SelectorDepartamento";
            SelectorDepartamento.SelectionMode = SelectionMode.MultiSimple;
            SelectorDepartamento.Size = new Size(275, 104);
            SelectorDepartamento.TabIndex = 2;
            SelectorDepartamento.SelectedIndexChanged += SelectorDepartamento_SelectedIndexChanged;
            // 
            // comboBoxAnios
            // 
            comboBoxAnios.FormattingEnabled = true;
            comboBoxAnios.Location = new Point(26, 302);
            comboBoxAnios.Name = "comboBoxAnios";
            comboBoxAnios.Size = new Size(275, 28);
            comboBoxAnios.TabIndex = 3;
            comboBoxAnios.SelectedIndexChanged += comboBoxAnios_SelectedIndexChanged;
            // 
            // comboBoxMeses
            // 
            comboBoxMeses.FormattingEnabled = true;
            comboBoxMeses.Location = new Point(26, 384);
            comboBoxMeses.Name = "comboBoxMeses";
            comboBoxMeses.Size = new Size(275, 28);
            comboBoxMeses.TabIndex = 4;
            comboBoxMeses.SelectedIndexChanged += comboBoxMeses_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 102);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 5;
            label2.Text = "Seleccionar Departamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 272);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 6;
            label3.Text = "Seleccionar Año:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 352);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 7;
            label4.Text = "Seleccionar Mes:";
            // 
            // Archivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 608);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxMeses);
            Controls.Add(comboBoxAnios);
            Controls.Add(SelectorDepartamento);
            Controls.Add(ListadodeVentarArch);
            Controls.Add(label1);
            Name = "Archivo";
            Text = "Archivo";
            Load += Archivo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel ListadodeVentarArch;
        private ListBox SelectorDepartamento;
        private ComboBox comboBoxAnios;
        private ComboBox comboBoxMeses;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}