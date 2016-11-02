﻿namespace Intersect_Editor.Forms.Editors
{
    partial class frmCrafting
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lstCrafts = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCompositions = new System.Windows.Forms.ListBox();
            this.btnNewComposition = new System.Windows.Forms.Button();
            this.btnDeleteCraft = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.scrlItem = new System.Windows.Forms.HScrollBar();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.scrlSpeed = new System.Windows.Forms.HScrollBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.scrlIngredient = new System.Windows.Forms.HScrollBar();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.scrlQuantity = new System.Windows.Forms.HScrollBar();
            this.groupBox1.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(544, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 27);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(333, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 27);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUndo);
            this.groupBox1.Controls.Add(this.lstCrafts);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 398);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benches";
            // 
            // btnUndo
            // 
            this.btnUndo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUndo.Location = new System.Drawing.Point(6, 360);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(190, 27);
            this.btnUndo.TabIndex = 22;
            this.btnUndo.Text = "Undo Changes";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lstCrafts
            // 
            this.lstCrafts.FormattingEnabled = true;
            this.lstCrafts.Location = new System.Drawing.Point(6, 19);
            this.lstCrafts.Name = "lstCrafts";
            this.lstCrafts.Size = new System.Drawing.Size(191, 264);
            this.lstCrafts.TabIndex = 1;
            this.lstCrafts.Click += new System.EventHandler(this.lstCrafts_Click);
            // 
            // btnNew
            // 
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNew.Location = new System.Drawing.Point(6, 294);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(190, 27);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Location = new System.Drawing.Point(7, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 27);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.groupBox2);
            this.pnlContainer.Controls.Add(this.groupBox3);
            this.pnlContainer.Controls.Add(this.groupBox5);
            this.pnlContainer.Location = new System.Drawing.Point(221, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(495, 398);
            this.pnlContainer.TabIndex = 31;
            this.pnlContainer.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCompositions);
            this.groupBox2.Controls.Add(this.btnNewComposition);
            this.groupBox2.Controls.Add(this.btnDeleteCraft);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 392);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crafts";
            // 
            // lstCompositions
            // 
            this.lstCompositions.FormattingEnabled = true;
            this.lstCompositions.Location = new System.Drawing.Point(6, 19);
            this.lstCompositions.Name = "lstCompositions";
            this.lstCompositions.Size = new System.Drawing.Size(191, 290);
            this.lstCompositions.TabIndex = 1;
            this.lstCompositions.Click += new System.EventHandler(this.lstCompositions_Click);
            // 
            // btnNewComposition
            // 
            this.btnNewComposition.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNewComposition.Location = new System.Drawing.Point(7, 321);
            this.btnNewComposition.Name = "btnNewComposition";
            this.btnNewComposition.Size = new System.Drawing.Size(190, 27);
            this.btnNewComposition.TabIndex = 20;
            this.btnNewComposition.Text = "New";
            this.btnNewComposition.UseVisualStyleBackColor = true;
            this.btnNewComposition.Click += new System.EventHandler(this.btnNewComposition_Click);
            // 
            // btnDeleteCraft
            // 
            this.btnDeleteCraft.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteCraft.Location = new System.Drawing.Point(7, 354);
            this.btnDeleteCraft.Name = "btnDeleteCraft";
            this.btnDeleteCraft.Size = new System.Drawing.Size(190, 27);
            this.btnDeleteCraft.TabIndex = 19;
            this.btnDeleteCraft.Text = "Delete";
            this.btnDeleteCraft.UseVisualStyleBackColor = true;
            this.btnDeleteCraft.Click += new System.EventHandler(this.btnDeleteCraft_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblItem);
            this.groupBox3.Controls.Add(this.scrlItem);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.lblSpeed);
            this.groupBox3.Controls.Add(this.scrlSpeed);
            this.groupBox3.Location = new System.Drawing.Point(212, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 113);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(10, 42);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(59, 13);
            this.lblItem.TabIndex = 33;
            this.lblItem.Text = "Item: None";
            // 
            // scrlItem
            // 
            this.scrlItem.LargeChange = 1;
            this.scrlItem.Location = new System.Drawing.Point(16, 55);
            this.scrlItem.Maximum = 5000;
            this.scrlItem.Minimum = -1;
            this.scrlItem.Name = "scrlItem";
            this.scrlItem.Size = new System.Drawing.Size(247, 17);
            this.scrlItem.TabIndex = 32;
            this.scrlItem.Value = -1;
            this.scrlItem.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlItem_Scroll);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(57, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 20);
            this.txtName.TabIndex = 18;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(10, 72);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(55, 13);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Time: 1ms";
            // 
            // scrlSpeed
            // 
            this.scrlSpeed.Location = new System.Drawing.Point(15, 85);
            this.scrlSpeed.Maximum = 5000;
            this.scrlSpeed.Minimum = 1;
            this.scrlSpeed.Name = "scrlSpeed";
            this.scrlSpeed.Size = new System.Drawing.Size(248, 17);
            this.scrlSpeed.TabIndex = 0;
            this.scrlSpeed.Value = 1;
            this.scrlSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlSpeed_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRemove);
            this.groupBox5.Controls.Add(this.btnAdd);
            this.groupBox5.Controls.Add(this.lblIngredient);
            this.groupBox5.Controls.Add(this.scrlIngredient);
            this.groupBox5.Controls.Add(this.lstIngredients);
            this.groupBox5.Controls.Add(this.lblQuantity);
            this.groupBox5.Controls.Add(this.scrlQuantity);
            this.groupBox5.Location = new System.Drawing.Point(212, 122);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(273, 242);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ingredients";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(188, 208);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(9, 141);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(59, 13);
            this.lblIngredient.TabIndex = 31;
            this.lblIngredient.Text = "Item: None";
            // 
            // scrlIngredient
            // 
            this.scrlIngredient.LargeChange = 1;
            this.scrlIngredient.Location = new System.Drawing.Point(12, 154);
            this.scrlIngredient.Maximum = 5000;
            this.scrlIngredient.Minimum = -1;
            this.scrlIngredient.Name = "scrlIngredient";
            this.scrlIngredient.Size = new System.Drawing.Size(251, 17);
            this.scrlIngredient.TabIndex = 30;
            this.scrlIngredient.Value = -1;
            this.scrlIngredient.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlIngredient_Scroll);
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Items.AddRange(new object[] {
            "Ingredient: None x1"});
            this.lstIngredients.Location = new System.Drawing.Point(12, 17);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(251, 121);
            this.lstIngredients.TabIndex = 29;
            this.lstIngredients.Click += new System.EventHandler(this.lstIngredients_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(10, 171);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 13);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Quantity: 1";
            // 
            // scrlQuantity
            // 
            this.scrlQuantity.LargeChange = 1;
            this.scrlQuantity.Location = new System.Drawing.Point(12, 184);
            this.scrlQuantity.Minimum = 1;
            this.scrlQuantity.Name = "scrlQuantity";
            this.scrlQuantity.Size = new System.Drawing.Size(251, 17);
            this.scrlQuantity.TabIndex = 27;
            this.scrlQuantity.Value = 1;
            this.scrlQuantity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlQuantity_Scroll);
            // 
            // frmCrafting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 449);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrafting";
            this.Text = "Crafting Bench Editor";
            this.groupBox1.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.ListBox lstCrafts;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.HScrollBar scrlItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.HScrollBar scrlSpeed;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.HScrollBar scrlIngredient;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.HScrollBar scrlQuantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstCompositions;
        private System.Windows.Forms.Button btnNewComposition;
        private System.Windows.Forms.Button btnDeleteCraft;
    }
}