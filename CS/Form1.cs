using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;

namespace UnboundNavigator {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form, INavigatableControl {
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Location = new System.Drawing.Point(8, 8);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.Size = new System.Drawing.Size(244, 21);
            this.controlNavigator1.TabIndex = 0;
            this.controlNavigator1.Text = "controlNavigator1";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.ItemHeight = 18;
            this.listBoxControl1.Location = new System.Drawing.Point(8, 48);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(245, 214);
            this.listBoxControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(264, 274);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.controlNavigator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.Run(new Form1());
        }

        #region INavigatableControl Members
        public int RecordCount {
            get { return 0; }
        }
        public int Position {
            get { return 0; }
        }
        public void AddNavigator(INavigatorOwner owner) { }
        public void RemoveNavigator(INavigatorOwner owner) { }

        public bool IsActionEnabled(NavigatorButtonType type) {
            // your code is here
            return true;
        }
        public void DoAction(NavigatorButtonType type) {
            // your code is here
            listBoxControl1.Items.Add(type.ToString());
            listBoxControl1.SelectedIndex = listBoxControl1.Items.Count - 1;
        }
        #endregion

        private void Form1_Load(object sender, System.EventArgs e) {
            controlNavigator1.NavigatableControl = this;
        }
    }
}
