namespace SGC_GRUPO4
{
    partial class EvaluateForm
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
            System.Windows.Forms.Label propietarioLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label iSO_14000Label;
            System.Windows.Forms.Label iSO_9001Label;
            System.Windows.Forms.Label no_ExpiradoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label id_ItemLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluateForm));
            this.propLabel2 = new System.Windows.Forms.Label();
            this.encargado = new System.Windows.Forms.Label();
            this.DGV_Evaluacion = new System.Windows.Forms.DataGridView();
            this.provtxt = new System.Windows.Forms.TextBox();
            this.evaluacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisEvaluacionDataSet2 = new SGC_GRUPO4.SisEvaluacionDataSet2();
            this.ISO14Check = new System.Windows.Forms.CheckBox();
            this.ISO90Check = new System.Windows.Forms.CheckBox();
            this.nExpCheck = new System.Windows.Forms.CheckBox();
            this.descriptxt = new System.Windows.Forms.TextBox();
            this.itemEvaluacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idtxt = new System.Windows.Forms.TextBox();
            this.labeltime = new System.Windows.Forms.Label();
            this.evaLabel = new System.Windows.Forms.Label();
            this.evaluacionTableAdapter = new SGC_GRUPO4.SisEvaluacionDataSet2TableAdapters.EvaluacionTableAdapter();
            this.tableAdapterManager = new SGC_GRUPO4.SisEvaluacionDataSet2TableAdapters.TableAdapterManager();
            this.itemEvaluacionTableAdapter = new SGC_GRUPO4.SisEvaluacionDataSet2TableAdapters.ItemEvaluacionTableAdapter();
            this.headertxt = new System.Windows.Forms.TextBox();
            this.titlelbl = new System.Windows.Forms.Label();
            this.titCalc = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            propietarioLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            iSO_14000Label = new System.Windows.Forms.Label();
            iSO_9001Label = new System.Windows.Forms.Label();
            no_ExpiradoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            id_ItemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Evaluacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisEvaluacionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemEvaluacionBindingSource)).BeginInit();
            this.titCalc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // propietarioLabel
            // 
            propietarioLabel.AutoSize = true;
            propietarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            propietarioLabel.Location = new System.Drawing.Point(71, 149);
            propietarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            propietarioLabel.Name = "propietarioLabel";
            propietarioLabel.Size = new System.Drawing.Size(88, 17);
            propietarioLabel.TabIndex = 6;
            propietarioLabel.Text = "Proveedor:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(347, 149);
            fechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(57, 17);
            fechaLabel.TabIndex = 8;
            fechaLabel.Text = "Fecha:";
            // 
            // iSO_14000Label
            // 
            iSO_14000Label.AutoSize = true;
            iSO_14000Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSO_14000Label.Location = new System.Drawing.Point(244, 206);
            iSO_14000Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iSO_14000Label.Name = "iSO_14000Label";
            iSO_14000Label.Size = new System.Drawing.Size(89, 17);
            iSO_14000Label.TabIndex = 10;
            iSO_14000Label.Text = "ISO 14000:";
            // 
            // iSO_9001Label
            // 
            iSO_9001Label.AutoSize = true;
            iSO_9001Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSO_9001Label.Location = new System.Drawing.Point(71, 206);
            iSO_9001Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iSO_9001Label.Name = "iSO_9001Label";
            iSO_9001Label.Size = new System.Drawing.Size(80, 17);
            iSO_9001Label.TabIndex = 12;
            iSO_9001Label.Text = "ISO 9001:";
            // 
            // no_ExpiradoLabel
            // 
            no_ExpiradoLabel.AutoSize = true;
            no_ExpiradoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_ExpiradoLabel.Location = new System.Drawing.Point(431, 206);
            no_ExpiradoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            no_ExpiradoLabel.Name = "no_ExpiradoLabel";
            no_ExpiradoLabel.Size = new System.Drawing.Size(101, 17);
            no_ExpiradoLabel.TabIndex = 14;
            no_ExpiradoLabel.Text = "No Expirado:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(315, 101);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(98, 17);
            descripcionLabel.TabIndex = 16;
            descripcionLabel.Text = "Descripcion:";
            // 
            // id_ItemLabel
            // 
            id_ItemLabel.AutoSize = true;
            id_ItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ItemLabel.Location = new System.Drawing.Point(89, 107);
            id_ItemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_ItemLabel.Name = "id_ItemLabel";
            id_ItemLabel.Size = new System.Drawing.Size(61, 17);
            id_ItemLabel.TabIndex = 17;
            id_ItemLabel.Text = "Id Item:";
            // 
            // propLabel2
            // 
            this.propLabel2.AutoSize = true;
            this.propLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propLabel2.Location = new System.Drawing.Point(321, 62);
            this.propLabel2.Name = "propLabel2";
            this.propLabel2.Size = new System.Drawing.Size(69, 17);
            this.propLabel2.TabIndex = 0;
            this.propLabel2.Text = "asdasdsa";
            // 
            // encargado
            // 
            this.encargado.AutoSize = true;
            this.encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encargado.Location = new System.Drawing.Point(224, 62);
            this.encargado.Name = "encargado";
            this.encargado.Size = new System.Drawing.Size(91, 17);
            this.encargado.TabIndex = 1;
            this.encargado.Text = "Encargado:";
            // 
            // DGV_Evaluacion
            // 
            this.DGV_Evaluacion.AllowUserToAddRows = false;
            this.DGV_Evaluacion.AllowUserToDeleteRows = false;
            this.DGV_Evaluacion.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.DGV_Evaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Evaluacion.Location = new System.Drawing.Point(13, 327);
            this.DGV_Evaluacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Evaluacion.Name = "DGV_Evaluacion";
            this.DGV_Evaluacion.ReadOnly = true;
            this.DGV_Evaluacion.Size = new System.Drawing.Size(1244, 231);
            this.DGV_Evaluacion.TabIndex = 3;
            this.DGV_Evaluacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Evaluacion_CellClick);
            // 
            // provtxt
            // 
            this.provtxt.BackColor = System.Drawing.Color.White;
            this.provtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evaluacionBindingSource, "Propietario", true));
            this.provtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provtxt.Location = new System.Drawing.Point(165, 145);
            this.provtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.provtxt.Name = "provtxt";
            this.provtxt.ReadOnly = true;
            this.provtxt.Size = new System.Drawing.Size(133, 23);
            this.provtxt.TabIndex = 7;
            // 
            // evaluacionBindingSource
            // 
            this.evaluacionBindingSource.DataMember = "Evaluacion";
            this.evaluacionBindingSource.DataSource = this.sisEvaluacionDataSet2;
            // 
            // sisEvaluacionDataSet2
            // 
            this.sisEvaluacionDataSet2.DataSetName = "SisEvaluacionDataSet2";
            this.sisEvaluacionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ISO14Check
            // 
            this.ISO14Check.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.evaluacionBindingSource, "ISO_14000", true));
            this.ISO14Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISO14Check.Location = new System.Drawing.Point(341, 199);
            this.ISO14Check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ISO14Check.Name = "ISO14Check";
            this.ISO14Check.Size = new System.Drawing.Size(28, 30);
            this.ISO14Check.TabIndex = 11;
            this.ISO14Check.UseVisualStyleBackColor = true;
            // 
            // ISO90Check
            // 
            this.ISO90Check.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.evaluacionBindingSource, "ISO_9001", true));
            this.ISO90Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISO90Check.Location = new System.Drawing.Point(163, 199);
            this.ISO90Check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ISO90Check.Name = "ISO90Check";
            this.ISO90Check.Size = new System.Drawing.Size(28, 30);
            this.ISO90Check.TabIndex = 13;
            this.ISO90Check.UseVisualStyleBackColor = true;
            // 
            // nExpCheck
            // 
            this.nExpCheck.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.evaluacionBindingSource, "No_Expirado", true));
            this.nExpCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nExpCheck.Location = new System.Drawing.Point(539, 199);
            this.nExpCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nExpCheck.Name = "nExpCheck";
            this.nExpCheck.Size = new System.Drawing.Size(28, 30);
            this.nExpCheck.TabIndex = 15;
            this.nExpCheck.UseVisualStyleBackColor = true;
            // 
            // descriptxt
            // 
            this.descriptxt.BackColor = System.Drawing.Color.White;
            this.descriptxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemEvaluacionBindingSource, "Descripcion", true));
            this.descriptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptxt.Location = new System.Drawing.Point(421, 98);
            this.descriptxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptxt.Multiline = true;
            this.descriptxt.Name = "descriptxt";
            this.descriptxt.ReadOnly = true;
            this.descriptxt.Size = new System.Drawing.Size(192, 29);
            this.descriptxt.TabIndex = 17;
            // 
            // itemEvaluacionBindingSource
            // 
            this.itemEvaluacionBindingSource.DataMember = "ItemEvaluacion";
            this.itemEvaluacionBindingSource.DataSource = this.sisEvaluacionDataSet2;
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.White;
            this.idtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemEvaluacionBindingSource, "Id_Item", true));
            this.idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(165, 103);
            this.idtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(133, 23);
            this.idtxt.TabIndex = 18;
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.Location = new System.Drawing.Point(421, 151);
            this.labeltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(46, 17);
            this.labeltime.TabIndex = 22;
            this.labeltime.Text = "label1";
            // 
            // evaLabel
            // 
            this.evaLabel.AutoSize = true;
            this.evaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaLabel.Location = new System.Drawing.Point(165, 164);
            this.evaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.evaLabel.Name = "evaLabel";
            this.evaLabel.Size = new System.Drawing.Size(28, 17);
            this.evaLabel.TabIndex = 23;
            this.evaLabel.Text = "0%";
            // 
            // evaluacionTableAdapter
            // 
            this.evaluacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EvaluacionTableAdapter = this.evaluacionTableAdapter;
            this.tableAdapterManager.ItemEvaluacionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGC_GRUPO4.SisEvaluacionDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemEvaluacionTableAdapter
            // 
            this.itemEvaluacionTableAdapter.ClearBeforeFill = true;
            // 
            // headertxt
            // 
            this.headertxt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.headertxt.Enabled = false;
            this.headertxt.Location = new System.Drawing.Point(-3, -2);
            this.headertxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headertxt.Multiline = true;
            this.headertxt.Name = "headertxt";
            this.headertxt.ReadOnly = true;
            this.headertxt.Size = new System.Drawing.Size(1273, 41);
            this.headertxt.TabIndex = 25;
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.titlelbl.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(517, 9);
            this.titlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(191, 23);
            this.titlelbl.TabIndex = 26;
            this.titlelbl.Text = "Evaluador de Calidad";
            // 
            // titCalc
            // 
            this.titCalc.Controls.Add(this.label1);
            this.titCalc.Controls.Add(this.pictureBox3);
            this.titCalc.Controls.Add(this.evaLabel);
            this.titCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titCalc.Location = new System.Drawing.Point(868, 62);
            this.titCalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titCalc.Name = "titCalc";
            this.titCalc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titCalc.Size = new System.Drawing.Size(352, 238);
            this.titCalc.TabIndex = 27;
            this.titCalc.TabStop = false;
            this.titCalc.Text = "Cálculo Indicador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Calidad";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SGC_GRUPO4.Properties.Resources.a40648d7_b571_45d2_8186_2937b577e17e;
            this.pictureBox3.Location = new System.Drawing.Point(125, 57);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SGC_GRUPO4.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(228, 244);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGC_GRUPO4.Properties.Resources.icono_modificar_png_6;
            this.pictureBox1.Location = new System.Drawing.Point(399, 244);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EvaluateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1269, 574);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titCalc);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.headertxt);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(id_ItemLabel);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descriptxt);
            this.Controls.Add(no_ExpiradoLabel);
            this.Controls.Add(this.nExpCheck);
            this.Controls.Add(iSO_9001Label);
            this.Controls.Add(this.ISO90Check);
            this.Controls.Add(iSO_14000Label);
            this.Controls.Add(this.ISO14Check);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(propietarioLabel);
            this.Controls.Add(this.provtxt);
            this.Controls.Add(this.DGV_Evaluacion);
            this.Controls.Add(this.encargado);
            this.Controls.Add(this.propLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EvaluateForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.EvaluateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Evaluacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisEvaluacionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemEvaluacionBindingSource)).EndInit();
            this.titCalc.ResumeLayout(false);
            this.titCalc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label propLabel2;
        private System.Windows.Forms.Label encargado;
        private SisEvaluacionDataSet2 sisEvaluacionDataSet2;
        private System.Windows.Forms.BindingSource evaluacionBindingSource;
        private SisEvaluacionDataSet2TableAdapters.EvaluacionTableAdapter evaluacionTableAdapter;
        private SisEvaluacionDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox provtxt;
        private System.Windows.Forms.BindingSource itemEvaluacionBindingSource;
        private SisEvaluacionDataSet2TableAdapters.ItemEvaluacionTableAdapter itemEvaluacionTableAdapter;
        private System.Windows.Forms.TextBox descriptxt;
        private System.Windows.Forms.TextBox idtxt;
        public System.Windows.Forms.DataGridView DGV_Evaluacion;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Label evaLabel;
        public System.Windows.Forms.CheckBox ISO14Check;
        public System.Windows.Forms.CheckBox ISO90Check;
        public System.Windows.Forms.CheckBox nExpCheck;
        private System.Windows.Forms.TextBox headertxt;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.GroupBox titCalc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}