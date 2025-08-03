namespace 弹出C盘
{
    partial class 弹出C盘
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(弹出C盘));
            弹出C盘按钮 = new Button();
            SuspendLayout();
            // 
            // 弹出C盘按钮
            // 
            resources.ApplyResources(弹出C盘按钮, "弹出C盘按钮");
            弹出C盘按钮.Name = "弹出C盘按钮";
            弹出C盘按钮.UseVisualStyleBackColor = true;
            弹出C盘按钮.Click += button1_Click;
            // 
            // 弹出C盘
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(弹出C盘按钮);
            Name = "弹出C盘";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button 弹出C盘按钮;
    }
}
