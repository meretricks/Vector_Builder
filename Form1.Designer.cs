namespace Vector.Builder
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
            this.visualWorkspace1 = new Vector.Builder.Pages.Components.VisualWorkspace();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tool_Selector = new System.Windows.Forms.Button();
            this.tool_VectorPointer = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualWorkspace1
            // 
            this.visualWorkspace1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.visualWorkspace1.BackColor = System.Drawing.Color.White;
            this.visualWorkspace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualWorkspace1.Location = new System.Drawing.Point(30, 0);
            this.visualWorkspace1.Name = "visualWorkspace1";
            this.visualWorkspace1.SelectedTool = Vector.Builder.Pages.Components.VisualWorkspace.Tools.Vector_Pointer;
            this.visualWorkspace1.Size = new System.Drawing.Size(647, 465);
            this.visualWorkspace1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.visualWorkspace1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 465);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.tool_Selector);
            this.flowLayoutPanel1.Controls.Add(this.tool_VectorPointer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(30, 465);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tool_Selector
            // 
            this.tool_Selector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tool_Selector.FlatAppearance.BorderSize = 0;
            this.tool_Selector.Image = global::Vector.Builder.Properties.Resources.Tool_Square;
            this.tool_Selector.Location = new System.Drawing.Point(2, 2);
            this.tool_Selector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.tool_Selector.Name = "tool_Selector";
            this.tool_Selector.Size = new System.Drawing.Size(26, 26);
            this.tool_Selector.TabIndex = 1;
            this.tool_Selector.UseMnemonic = false;
            this.tool_Selector.UseVisualStyleBackColor = false;
            this.tool_Selector.Click += new System.EventHandler(this.tool_Selector_Click);
            // 
            // tool_VectorPointer
            // 
            this.tool_VectorPointer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tool_VectorPointer.FlatAppearance.BorderSize = 0;
            this.tool_VectorPointer.Image = global::Vector.Builder.Properties.Resources.Vector2DMarker;
            this.tool_VectorPointer.Location = new System.Drawing.Point(2, 30);
            this.tool_VectorPointer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.tool_VectorPointer.Name = "tool_VectorPointer";
            this.tool_VectorPointer.Size = new System.Drawing.Size(26, 26);
            this.tool_VectorPointer.TabIndex = 0;
            this.tool_VectorPointer.UseMnemonic = false;
            this.tool_VectorPointer.UseVisualStyleBackColor = false;
            this.tool_VectorPointer.Click += new System.EventHandler(this.tool_VectorPointer_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(677, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 465);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.propertyGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(680, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 465);
            this.panel2.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid1.SelectedObject = this.visualWorkspace1;
            this.propertyGrid1.Size = new System.Drawing.Size(183, 465);
            this.propertyGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 465);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Pages.Components.VisualWorkspace visualWorkspace1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button tool_VectorPointer;
        private System.Windows.Forms.Button tool_Selector;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}

