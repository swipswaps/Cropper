namespace Fusion8.Cropper.Core
{
    partial class HotKeySelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
                                                                                                                     "Show",
                                                                                                                     "",
                                                                                                                     "Yes"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
                                                                                                                     "Hide",
                                                                                                                     "",
                                                                                                                     "No"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
                                                                                                                     "Thumbnail",
                                                                                                                     "",
                                                                                                                     "No"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
                                                                                                                     "Next Size",
                                                                                                                     "",
                                                                                                                     "No"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
                                                                                                                     "Capture",
                                                                                                                     "",
                                                                                                                     "Yes"}, -1);
            this.shortcutList = new System.Windows.Forms.ListView();
            this.actionHeader = new System.Windows.Forms.ColumnHeader();
            this.shortcutHeader = new System.Windows.Forms.ColumnHeader();
            this.globalHeader = new System.Windows.Forms.ColumnHeader();
            this.shortcutAssign = new System.Windows.Forms.Button();
            this.shortcut = new Fusion8.Cropper.Core.ShortcutTextBox();
            this.SuspendLayout();
            // 
            // shortcutList
            // 
            this.shortcutList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                              | System.Windows.Forms.AnchorStyles.Left)
                                                                             | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                           this.actionHeader,
                                                                                           this.shortcutHeader,
                                                                                           this.globalHeader});
            this.shortcutList.FullRowSelect = true;
            this.shortcutList.GridLines = true;
            this.shortcutList.HideSelection = false;
            this.shortcutList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
                                                                                         listViewItem1,
                                                                                         listViewItem2,
                                                                                         listViewItem3,
                                                                                         listViewItem4,
                                                                                         listViewItem5});
            this.shortcutList.Location = new System.Drawing.Point(3, 3);
            this.shortcutList.Name = "shortcutList";
            this.shortcutList.Size = new System.Drawing.Size(261, 115);
            this.shortcutList.TabIndex = 5;
            this.shortcutList.UseCompatibleStateImageBehavior = false;
            this.shortcutList.View = System.Windows.Forms.View.Details;
            this.shortcutList.SelectedIndexChanged += new System.EventHandler(this.HandleShortcutListSelectedIndexChanged);
            // 
            // actionHeader
            // 
            this.actionHeader.Text = "Action";
            this.actionHeader.Width = 73;
            // 
            // shortcutHeader
            // 
            this.shortcutHeader.Text = "Shortcut";
            this.shortcutHeader.Width = 124;
            // 
            // globalHeader
            // 
            this.globalHeader.Text = "Global";
            this.globalHeader.Width = 49;
            // 
            // shortcutAssign
            // 
            this.shortcutAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutAssign.Location = new System.Drawing.Point(189, 123);
            this.shortcutAssign.Name = "shortcutAssign";
            this.shortcutAssign.Size = new System.Drawing.Size(75, 22);
            this.shortcutAssign.TabIndex = 4;
            this.shortcutAssign.Text = "Assign";
            this.shortcutAssign.UseVisualStyleBackColor = true;
            this.shortcutAssign.Click += new System.EventHandler(this.HandleShorcutAssignClick);
            // 
            // shortcut
            // 
            this.shortcut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcut.Location = new System.Drawing.Point(3, 125);
            this.shortcut.Name = "shortcut";
            this.shortcut.Size = new System.Drawing.Size(180, 20);
            this.shortcut.TabIndex = 3;
            // 
            // HotKeySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shortcutList);
            this.Controls.Add(this.shortcutAssign);
            this.Controls.Add(this.shortcut);
            this.Name = "HotKeySelection";
            this.Size = new System.Drawing.Size(267, 152);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView shortcutList;
        private System.Windows.Forms.ColumnHeader actionHeader;
        private System.Windows.Forms.ColumnHeader shortcutHeader;
        private System.Windows.Forms.ColumnHeader globalHeader;
        private System.Windows.Forms.Button shortcutAssign;
        private Fusion8.Cropper.Core.ShortcutTextBox shortcut;
    }
}