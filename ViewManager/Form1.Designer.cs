namespace ViewManager
{
	partial class ViewManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewManager));
			this.buttonControlLine = new System.Windows.Forms.Button();
			this.buttonOff = new System.Windows.Forms.Button();
			this.buttonOn = new System.Windows.Forms.Button();
			this.buttonControlPoint = new System.Windows.Forms.Button();
			this.buttonBaseComponent = new System.Windows.Forms.Button();
			this.buttonBaseWeld = new System.Windows.Forms.Button();
			this.buttonPart = new System.Windows.Forms.Button();
			this.buttonBoltGroup = new System.Windows.Forms.Button();
			this.buttonCutFitting = new System.Windows.Forms.Button();
			this.listBoxViews = new System.Windows.Forms.ListBox();
			this.buttonDeleteView = new System.Windows.Forms.Button();
			this.buttonCloseView = new System.Windows.Forms.Button();
			this.buttonOpenView = new System.Windows.Forms.Button();
			this.groupBoxQuickOnOff = new System.Windows.Forms.GroupBox();
			this.groupBoxOnOff = new System.Windows.Forms.GroupBox();
			this.groupBoxViews = new System.Windows.Forms.GroupBox();
			this.buttonCloseAllViews = new System.Windows.Forms.Button();
			this.buttonCloseCurrentView = new System.Windows.Forms.Button();
			this.buttonAllOff = new System.Windows.Forms.Button();
			this.groupBoxQuickOnOff.SuspendLayout();
			this.groupBoxOnOff.SuspendLayout();
			this.groupBoxViews.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonControlLine
			// 
			this.buttonControlLine.Location = new System.Drawing.Point(6, 31);
			this.buttonControlLine.Name = "buttonControlLine";
			this.buttonControlLine.Size = new System.Drawing.Size(110, 46);
			this.buttonControlLine.TabIndex = 0;
			this.buttonControlLine.Text = "Control Line";
			this.buttonControlLine.UseVisualStyleBackColor = true;
			this.buttonControlLine.Click += new System.EventHandler(this.buttonControlLines_Click);
			// 
			// buttonOff
			// 
			this.buttonOff.Location = new System.Drawing.Point(238, 21);
			this.buttonOff.Name = "buttonOff";
			this.buttonOff.Size = new System.Drawing.Size(111, 44);
			this.buttonOff.TabIndex = 1;
			this.buttonOff.Text = "Single OFF";
			this.buttonOff.UseVisualStyleBackColor = true;
			this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
			// 
			// buttonOn
			// 
			this.buttonOn.Location = new System.Drawing.Point(7, 21);
			this.buttonOn.Name = "buttonOn";
			this.buttonOn.Size = new System.Drawing.Size(109, 44);
			this.buttonOn.TabIndex = 2;
			this.buttonOn.Text = "All ON";
			this.buttonOn.UseVisualStyleBackColor = true;
			this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
			// 
			// buttonControlPoint
			// 
			this.buttonControlPoint.Location = new System.Drawing.Point(6, 83);
			this.buttonControlPoint.Name = "buttonControlPoint";
			this.buttonControlPoint.Size = new System.Drawing.Size(110, 46);
			this.buttonControlPoint.TabIndex = 3;
			this.buttonControlPoint.Text = "Control Point";
			this.buttonControlPoint.UseVisualStyleBackColor = true;
			this.buttonControlPoint.Click += new System.EventHandler(this.buttonControlPoint_Click);
			// 
			// buttonBaseComponent
			// 
			this.buttonBaseComponent.Location = new System.Drawing.Point(122, 83);
			this.buttonBaseComponent.Name = "buttonBaseComponent";
			this.buttonBaseComponent.Size = new System.Drawing.Size(110, 46);
			this.buttonBaseComponent.TabIndex = 4;
			this.buttonBaseComponent.Text = "Base Component";
			this.buttonBaseComponent.UseVisualStyleBackColor = true;
			this.buttonBaseComponent.Click += new System.EventHandler(this.buttonBaseComponent_Click);
			// 
			// buttonBaseWeld
			// 
			this.buttonBaseWeld.Location = new System.Drawing.Point(122, 31);
			this.buttonBaseWeld.Name = "buttonBaseWeld";
			this.buttonBaseWeld.Size = new System.Drawing.Size(110, 46);
			this.buttonBaseWeld.TabIndex = 5;
			this.buttonBaseWeld.Text = "Base Weld";
			this.buttonBaseWeld.UseVisualStyleBackColor = true;
			this.buttonBaseWeld.Click += new System.EventHandler(this.buttonBaseWeld_Click);
			// 
			// buttonPart
			// 
			this.buttonPart.Location = new System.Drawing.Point(238, 31);
			this.buttonPart.Name = "buttonPart";
			this.buttonPart.Size = new System.Drawing.Size(110, 46);
			this.buttonPart.TabIndex = 6;
			this.buttonPart.Text = "Part";
			this.buttonPart.UseVisualStyleBackColor = true;
			this.buttonPart.Click += new System.EventHandler(this.buttonPart_Click);
			// 
			// buttonBoltGroup
			// 
			this.buttonBoltGroup.Location = new System.Drawing.Point(238, 83);
			this.buttonBoltGroup.Name = "buttonBoltGroup";
			this.buttonBoltGroup.Size = new System.Drawing.Size(110, 46);
			this.buttonBoltGroup.TabIndex = 7;
			this.buttonBoltGroup.Text = "Bolt Group";
			this.buttonBoltGroup.UseVisualStyleBackColor = true;
			this.buttonBoltGroup.Click += new System.EventHandler(this.buttonBoltGroup_Click);
			// 
			// buttonCutFitting
			// 
			this.buttonCutFitting.Location = new System.Drawing.Point(122, 135);
			this.buttonCutFitting.Name = "buttonCutFitting";
			this.buttonCutFitting.Size = new System.Drawing.Size(110, 46);
			this.buttonCutFitting.TabIndex = 8;
			this.buttonCutFitting.Text = "Cut/Fitting";
			this.buttonCutFitting.UseVisualStyleBackColor = true;
			this.buttonCutFitting.Click += new System.EventHandler(this.buttonCutFitting_Click);
			// 
			// listBoxViews
			// 
			this.listBoxViews.FormattingEnabled = true;
			this.listBoxViews.ItemHeight = 16;
			this.listBoxViews.Location = new System.Drawing.Point(6, 21);
			this.listBoxViews.Name = "listBoxViews";
			this.listBoxViews.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxViews.Size = new System.Drawing.Size(341, 228);
			this.listBoxViews.TabIndex = 9;
			this.listBoxViews.DoubleClick += new System.EventHandler(this.listBoxViews_DoubleClick);
			// 
			// buttonDeleteView
			// 
			this.buttonDeleteView.Location = new System.Drawing.Point(238, 255);
			this.buttonDeleteView.Name = "buttonDeleteView";
			this.buttonDeleteView.Size = new System.Drawing.Size(110, 46);
			this.buttonDeleteView.TabIndex = 12;
			this.buttonDeleteView.Text = "Delete";
			this.buttonDeleteView.UseVisualStyleBackColor = true;
			this.buttonDeleteView.Click += new System.EventHandler(this.buttonDeleteView_Click);
			// 
			// buttonCloseView
			// 
			this.buttonCloseView.Location = new System.Drawing.Point(121, 255);
			this.buttonCloseView.Name = "buttonCloseView";
			this.buttonCloseView.Size = new System.Drawing.Size(110, 46);
			this.buttonCloseView.TabIndex = 11;
			this.buttonCloseView.Text = "Close";
			this.buttonCloseView.UseVisualStyleBackColor = true;
			this.buttonCloseView.Click += new System.EventHandler(this.buttonCloseView_Click);
			// 
			// buttonOpenView
			// 
			this.buttonOpenView.Location = new System.Drawing.Point(5, 255);
			this.buttonOpenView.Name = "buttonOpenView";
			this.buttonOpenView.Size = new System.Drawing.Size(110, 46);
			this.buttonOpenView.TabIndex = 10;
			this.buttonOpenView.Text = "Open";
			this.buttonOpenView.UseVisualStyleBackColor = true;
			this.buttonOpenView.Click += new System.EventHandler(this.buttonOpenView_Click);
			// 
			// groupBoxQuickOnOff
			// 
			this.groupBoxQuickOnOff.Controls.Add(this.buttonBaseWeld);
			this.groupBoxQuickOnOff.Controls.Add(this.buttonControlLine);
			this.groupBoxQuickOnOff.Controls.Add(this.buttonControlPoint);
			this.groupBoxQuickOnOff.Controls.Add(this.buttonBaseComponent);
			this.groupBoxQuickOnOff.Controls.Add(this.buttonPart);
			this.groupBoxQuickOnOff.Controls.Add(this.buttonBoltGroup);
			this.groupBoxQuickOnOff.Controls.Add(this.buttonCutFitting);
			this.groupBoxQuickOnOff.Location = new System.Drawing.Point(11, 12);
			this.groupBoxQuickOnOff.Name = "groupBoxQuickOnOff";
			this.groupBoxQuickOnOff.Size = new System.Drawing.Size(356, 192);
			this.groupBoxQuickOnOff.TabIndex = 14;
			this.groupBoxQuickOnOff.TabStop = false;
			this.groupBoxQuickOnOff.Text = "Quick On/Off";
			// 
			// groupBoxOnOff
			// 
			this.groupBoxOnOff.Controls.Add(this.buttonAllOff);
			this.groupBoxOnOff.Controls.Add(this.buttonOff);
			this.groupBoxOnOff.Controls.Add(this.buttonOn);
			this.groupBoxOnOff.Location = new System.Drawing.Point(11, 210);
			this.groupBoxOnOff.Name = "groupBoxOnOff";
			this.groupBoxOnOff.Size = new System.Drawing.Size(357, 79);
			this.groupBoxOnOff.TabIndex = 15;
			this.groupBoxOnOff.TabStop = false;
			this.groupBoxOnOff.Text = "On/Off";
			// 
			// groupBoxViews
			// 
			this.groupBoxViews.Controls.Add(this.buttonCloseAllViews);
			this.groupBoxViews.Controls.Add(this.buttonCloseCurrentView);
			this.groupBoxViews.Controls.Add(this.listBoxViews);
			this.groupBoxViews.Controls.Add(this.buttonOpenView);
			this.groupBoxViews.Controls.Add(this.buttonCloseView);
			this.groupBoxViews.Controls.Add(this.buttonDeleteView);
			this.groupBoxViews.Location = new System.Drawing.Point(11, 295);
			this.groupBoxViews.Name = "groupBoxViews";
			this.groupBoxViews.Size = new System.Drawing.Size(357, 365);
			this.groupBoxViews.TabIndex = 16;
			this.groupBoxViews.TabStop = false;
			this.groupBoxViews.Text = "Views";
			// 
			// buttonCloseAllViews
			// 
			this.buttonCloseAllViews.Location = new System.Drawing.Point(177, 307);
			this.buttonCloseAllViews.Name = "buttonCloseAllViews";
			this.buttonCloseAllViews.Size = new System.Drawing.Size(171, 46);
			this.buttonCloseAllViews.TabIndex = 14;
			this.buttonCloseAllViews.Text = "Close All Views";
			this.buttonCloseAllViews.UseVisualStyleBackColor = true;
			this.buttonCloseAllViews.Click += new System.EventHandler(this.buttonCloseAllViews_Click);
			// 
			// buttonCloseCurrentView
			// 
			this.buttonCloseCurrentView.Location = new System.Drawing.Point(5, 307);
			this.buttonCloseCurrentView.Name = "buttonCloseCurrentView";
			this.buttonCloseCurrentView.Size = new System.Drawing.Size(166, 46);
			this.buttonCloseCurrentView.TabIndex = 13;
			this.buttonCloseCurrentView.Text = "Close Selected Views";
			this.buttonCloseCurrentView.UseVisualStyleBackColor = true;
			this.buttonCloseCurrentView.Click += new System.EventHandler(this.buttonCloseSelectedViews_Click);
			// 
			// buttonAllOff
			// 
			this.buttonAllOff.Location = new System.Drawing.Point(123, 21);
			this.buttonAllOff.Name = "buttonAllOff";
			this.buttonAllOff.Size = new System.Drawing.Size(109, 44);
			this.buttonAllOff.TabIndex = 3;
			this.buttonAllOff.Text = "All OFF";
			this.buttonAllOff.UseVisualStyleBackColor = true;
			this.buttonAllOff.Click += new System.EventHandler(this.buttonAllOff_Click);
			// 
			// ViewManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 674);
			this.Controls.Add(this.groupBoxViews);
			this.Controls.Add(this.groupBoxOnOff);
			this.Controls.Add(this.groupBoxQuickOnOff);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ViewManager";
			this.Text = "View Manager";
			this.TopMost = true;
			this.groupBoxQuickOnOff.ResumeLayout(false);
			this.groupBoxOnOff.ResumeLayout(false);
			this.groupBoxViews.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonControlLine;
		private System.Windows.Forms.Button buttonOff;
		private System.Windows.Forms.Button buttonOn;
		private System.Windows.Forms.Button buttonControlPoint;
		private System.Windows.Forms.Button buttonBaseComponent;
		private System.Windows.Forms.Button buttonBaseWeld;
		private System.Windows.Forms.Button buttonPart;
		private System.Windows.Forms.Button buttonBoltGroup;
		private System.Windows.Forms.Button buttonCutFitting;
		private System.Windows.Forms.ListBox listBoxViews;
		private System.Windows.Forms.Button buttonDeleteView;
		private System.Windows.Forms.Button buttonCloseView;
		private System.Windows.Forms.Button buttonOpenView;
		private System.Windows.Forms.GroupBox groupBoxQuickOnOff;
		private System.Windows.Forms.GroupBox groupBoxOnOff;
		private System.Windows.Forms.GroupBox groupBoxViews;
		private System.Windows.Forms.Button buttonCloseAllViews;
		private System.Windows.Forms.Button buttonCloseCurrentView;
		private System.Windows.Forms.Button buttonAllOff;
	}
}

