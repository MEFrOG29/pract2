namespace pr2t3
{
    partial class CreateMultiplicationTableForm
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
            createButton = new Button();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Location = new Point(28, 55);
            createButton.Name = "createButton";
            createButton.Size = new Size(747, 307);
            createButton.TabIndex = 0;
            createButton.Text = "Таблица умножения";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += CreateButton_Click;
            // 
            // CreateMultiplicationTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createButton);
            Name = "CreateMultiplicationTableForm";
            Text = "Создатель таблицы умножения";
            ResumeLayout(false);
        }

        #endregion

        private Button createButton;
    }
}
