namespace WinFormsAppSinFuenteDeDato
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonPanel = new Panel();
            songsDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            addNewRowButton = new Button();
            deleteRowButton = new Button();
            buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)songsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = SystemColors.ActiveCaption;
            buttonPanel.Controls.Add(songsDataGridView);
            buttonPanel.Location = new Point(49, 123);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(716, 346);
            buttonPanel.TabIndex = 0;
            // 
            // songsDataGridView
            // 
            songsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            songsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            songsDataGridView.Location = new Point(30, 3);
            songsDataGridView.MultiSelect = false;
            songsDataGridView.Name = "songsDataGridView";
            songsDataGridView.RowTemplate.Height = 25;
            songsDataGridView.Size = new Size(652, 321);
            songsDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Año de lanzamiento";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Pista";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Titulo";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Artista";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Album";
            Column5.Name = "Column5";
            // 
            // addNewRowButton
            // 
            addNewRowButton.Location = new Point(49, 45);
            addNewRowButton.Name = "addNewRowButton";
            addNewRowButton.Size = new Size(109, 49);
            addNewRowButton.TabIndex = 2;
            addNewRowButton.Text = "agregar";
            addNewRowButton.UseVisualStyleBackColor = true;
            addNewRowButton.Click += addNewRowButton_Click;
            // 
            // deleteRowButton
            // 
            deleteRowButton.Location = new Point(182, 45);
            deleteRowButton.Name = "deleteRowButton";
            deleteRowButton.Size = new Size(103, 49);
            deleteRowButton.TabIndex = 3;
            deleteRowButton.Text = "eliminar";
            deleteRowButton.UseVisualStyleBackColor = true;
            deleteRowButton.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 504);
            Controls.Add(deleteRowButton);
            Controls.Add(addNewRowButton);
            Controls.Add(buttonPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)songsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel buttonPanel;
        private DataGridView songsDataGridView;
        private Button addNewRowButton;
        private Button deleteRowButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}