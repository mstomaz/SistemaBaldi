namespace FinishControl.Views
{
    partial class FinishControlMainView
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
            finishControlGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)finishControlGrid).BeginInit();
            SuspendLayout();
            // 
            // finishControlGrid
            // 
            finishControlGrid.AllowUserToOrderColumns = true;
            finishControlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            finishControlGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            finishControlGrid.Location = new Point(0, 0);
            finishControlGrid.Name = "finishControlGrid";
            finishControlGrid.Size = new Size(918, 399);
            finishControlGrid.TabIndex = 0;
            // 
            // FinishControlMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 430);
            Controls.Add(finishControlGrid);
            Name = "FinishControlMainView";
            Text = "Controle de Pedidos";
            ((System.ComponentModel.ISupportInitialize)finishControlGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView finishControlGrid;
    }
}