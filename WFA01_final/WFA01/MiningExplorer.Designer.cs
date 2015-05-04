namespace WFA01
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.legMain = new DotSpatial.Controls.Legend();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabViewMap = new System.Windows.Forms.TabPage();
            this.mapMain = new DotSpatial.Controls.Map();
            this.appManager1 = new DotSpatial.Controls.AppManager();
            this.spatialDockManager1 = new DotSpatial.Controls.SpatialDockManager();
            this.spatialHeaderControl1 = new DotSpatial.Controls.SpatialHeaderControl();
            this.spatialStatusStrip1 = new DotSpatial.Controls.SpatialStatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.stax = new System.Windows.Forms.ToolStripStatusLabel();
            this.stay = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMain = new System.Windows.Forms.ToolStripMenuItem();
            this.newProject = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsProject = new System.Windows.Forms.ToolStripMenuItem();
            this.openProject = new System.Windows.Forms.ToolStripMenuItem();
            this.layersMain = new System.Windows.Forms.ToolStripMenuItem();
            this.addLayerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLayerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMain = new System.Windows.Forms.ToolStripMenuItem();
            this.viewElevationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToExtentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMain = new System.Windows.Forms.ToolStripMenuItem();
            this.createCutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createFillMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.caculatorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cutElevation = new System.Windows.Forms.Label();
            this.txtCutElevation = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddLayer = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveLayer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPan = new System.Windows.Forms.ToolStripButton();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCreateCutPolygon = new System.Windows.Forms.ToolStripButton();
            this.btnCreateFillPolygon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnViewElevation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabContainer.SuspendLayout();
            this.tabViewMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).BeginInit();
            this.spatialDockManager1.Panel1.SuspendLayout();
            this.spatialDockManager1.Panel2.SuspendLayout();
            this.spatialDockManager1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl1)).BeginInit();
            this.spatialStatusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // legMain
            // 
            this.legMain.BackColor = System.Drawing.Color.White;
            this.legMain.ControlRectangle = new System.Drawing.Rectangle(0, 0, 163, 513);
            resources.ApplyResources(this.legMain, "legMain");
            this.legMain.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legMain.HorizontalScrollEnabled = true;
            this.legMain.Indentation = 30;
            this.legMain.IsInitialized = false;
            this.legMain.Name = "legMain";
            this.legMain.ProgressHandler = null;
            this.legMain.ResetOnResize = false;
            this.legMain.SelectionFontColor = System.Drawing.Color.Black;
            this.legMain.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legMain.VerticalScrollEnabled = true;
            // 
            // tabContainer
            // 
            resources.ApplyResources(this.tabContainer, "tabContainer");
            this.tabContainer.Controls.Add(this.tabViewMap);
            this.tabContainer.Multiline = true;
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            // 
            // tabViewMap
            // 
            this.tabViewMap.Controls.Add(this.mapMain);
            resources.ApplyResources(this.tabViewMap, "tabViewMap");
            this.tabViewMap.Name = "tabViewMap";
            this.tabViewMap.UseVisualStyleBackColor = true;
            // 
            // mapMain
            // 
            this.mapMain.AllowDrop = true;
            this.mapMain.BackColor = System.Drawing.Color.White;
            this.mapMain.CollectAfterDraw = false;
            this.mapMain.CollisionDetection = false;
            resources.ApplyResources(this.mapMain, "mapMain");
            this.mapMain.ExtendBuffer = false;
            this.mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.mapMain.IsBusy = false;
            this.mapMain.IsZoomedToMaxExtent = false;
            this.mapMain.Legend = this.legMain;
            this.mapMain.Name = "mapMain";
            this.mapMain.ProgressHandler = null;
            this.mapMain.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.mapMain.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.mapMain.RedrawLayersWhileResizing = false;
            this.mapMain.SelectionEnabled = true;
            this.mapMain.Click += new System.EventHandler(this.mapMain_Click);
            this.mapMain.DoubleClick += new System.EventHandler(this.mapMain_DoubleClick);
            this.mapMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapMouseMove1);
            // 
            // appManager1
            // 
            this.appManager1.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager1.Directories")));
            this.appManager1.DockManager = this.spatialDockManager1;
            this.appManager1.HeaderControl = this.spatialHeaderControl1;
            this.appManager1.Legend = this.legMain;
            this.appManager1.Map = this.mapMain;
            this.appManager1.ProgressHandler = this.spatialStatusStrip1;
            this.appManager1.ShowExtensionsDialogMode = DotSpatial.Controls.ShowExtensionsDialogMode.Default;
            // 
            // spatialDockManager1
            // 
            resources.ApplyResources(this.spatialDockManager1, "spatialDockManager1");
            this.spatialDockManager1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spatialDockManager1.Name = "spatialDockManager1";
            // 
            // spatialDockManager1.Panel1
            // 
            this.spatialDockManager1.Panel1.Controls.Add(this.legMain);
            // 
            // spatialDockManager1.Panel2
            // 
            this.spatialDockManager1.Panel2.Controls.Add(this.tabContainer);
            this.spatialDockManager1.TabControl1 = this.tabContainer;
            this.spatialDockManager1.TabControl2 = this.tabContainer;
            // 
            // spatialHeaderControl1
            // 
            this.spatialHeaderControl1.ApplicationManager = null;
            this.spatialHeaderControl1.MenuStrip = null;
            this.spatialHeaderControl1.ToolbarsContainer = null;
            // 
            // spatialStatusStrip1
            // 
            this.spatialStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar1,
            this.stax,
            this.stay});
            resources.ApplyResources(this.spatialStatusStrip1, "spatialStatusStrip1");
            this.spatialStatusStrip1.Name = "spatialStatusStrip1";
            this.spatialStatusStrip1.ProgressBar = this.ProgressBar1;
            this.spatialStatusStrip1.ProgressLabel = this.stax;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Name = "ProgressBar1";
            resources.ApplyResources(this.ProgressBar1, "ProgressBar1");
            // 
            // stax
            // 
            this.stax.Name = "stax";
            resources.ApplyResources(this.stax, "stax");
            // 
            // stay
            // 
            this.stay.Name = "stay";
            resources.ApplyResources(this.stay, "stay");
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMain,
            this.layersMain,
            this.viewMain,
            this.insertMain,
            this.caculatorMenu});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileMain
            // 
            this.fileMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProject,
            this.saveProject,
            this.saveAsProject,
            this.openProject,
            this.exitToolStripMenuItem});
            this.fileMain.Name = "fileMain";
            resources.ApplyResources(this.fileMain, "fileMain");
            // 
            // newProject
            // 
            this.newProject.Name = "newProject";
            resources.ApplyResources(this.newProject, "newProject");
            // 
            // saveProject
            // 
            this.saveProject.Name = "saveProject";
            resources.ApplyResources(this.saveProject, "saveProject");
            // 
            // saveAsProject
            // 
            this.saveAsProject.Name = "saveAsProject";
            resources.ApplyResources(this.saveAsProject, "saveAsProject");
            // 
            // openProject
            // 
            this.openProject.Name = "openProject";
            resources.ApplyResources(this.openProject, "openProject");
            // 
            // layersMain
            // 
            this.layersMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLayerMenu,
            this.removeLayerMenu});
            this.layersMain.Name = "layersMain";
            resources.ApplyResources(this.layersMain, "layersMain");
            // 
            // addLayerMenu
            // 
            this.addLayerMenu.Name = "addLayerMenu";
            resources.ApplyResources(this.addLayerMenu, "addLayerMenu");
            this.addLayerMenu.Click += new System.EventHandler(this.addLayerToolStripMenuItem_Click);
            // 
            // removeLayerMenu
            // 
            this.removeLayerMenu.Name = "removeLayerMenu";
            resources.ApplyResources(this.removeLayerMenu, "removeLayerMenu");
            this.removeLayerMenu.Click += new System.EventHandler(this.removeLayerToolStripMenuItem_Click);
            // 
            // viewMain
            // 
            this.viewMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewElevationsToolStripMenuItem,
            this.zoomInMenu,
            this.zoomOutMenu,
            this.zoomToExtentMenu,
            this.panMenu});
            this.viewMain.Name = "viewMain";
            resources.ApplyResources(this.viewMain, "viewMain");
            // 
            // viewElevationsToolStripMenuItem
            // 
            this.viewElevationsToolStripMenuItem.Name = "viewElevationsToolStripMenuItem";
            resources.ApplyResources(this.viewElevationsToolStripMenuItem, "viewElevationsToolStripMenuItem");
            this.viewElevationsToolStripMenuItem.Click += new System.EventHandler(this.viewElevationsToolStripMenuItem_Click);
            // 
            // zoomInMenu
            // 
            resources.ApplyResources(this.zoomInMenu, "zoomInMenu");
            this.zoomInMenu.Name = "zoomInMenu";
            this.zoomInMenu.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click_1);
            // 
            // zoomOutMenu
            // 
            resources.ApplyResources(this.zoomOutMenu, "zoomOutMenu");
            this.zoomOutMenu.Name = "zoomOutMenu";
            this.zoomOutMenu.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click_1);
            // 
            // zoomToExtentMenu
            // 
            this.zoomToExtentMenu.Name = "zoomToExtentMenu";
            resources.ApplyResources(this.zoomToExtentMenu, "zoomToExtentMenu");
            this.zoomToExtentMenu.Click += new System.EventHandler(this.zoomToExtentMenu_Click);
            // 
            // panMenu
            // 
            resources.ApplyResources(this.panMenu, "panMenu");
            this.panMenu.Name = "panMenu";
            this.panMenu.Click += new System.EventHandler(this.panMenu_Click);
            // 
            // insertMain
            // 
            this.insertMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCutMenu,
            this.createFillMenu});
            this.insertMain.Name = "insertMain";
            resources.ApplyResources(this.insertMain, "insertMain");
            // 
            // createCutMenu
            // 
            this.createCutMenu.Name = "createCutMenu";
            resources.ApplyResources(this.createCutMenu, "createCutMenu");
            this.createCutMenu.Click += new System.EventHandler(this.creatCutMenu_Click);
            // 
            // createFillMenu
            // 
            this.createFillMenu.Name = "createFillMenu";
            resources.ApplyResources(this.createFillMenu, "createFillMenu");
            this.createFillMenu.Click += new System.EventHandler(this.createFillMenu_Click);
            // 
            // caculatorMenu
            // 
            this.caculatorMenu.Name = "caculatorMenu";
            resources.ApplyResources(this.caculatorMenu, "caculatorMenu");
            this.caculatorMenu.Click += new System.EventHandler(this.caculatorToolStripMenuItem_Click);
            // 
            // cutElevation
            // 
            resources.ApplyResources(this.cutElevation, "cutElevation");
            this.cutElevation.Name = "cutElevation";
            // 
            // txtCutElevation
            // 
            resources.ApplyResources(this.txtCutElevation, "txtCutElevation");
            this.txtCutElevation.Name = "txtCutElevation";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddLayer,
            this.btnRemoveLayer,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnPan,
            this.btnZoomIn,
            this.btnZoomOut,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btnCreateCutPolygon,
            this.btnCreateFillPolygon,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.toolStripButton1,
            this.btnViewElevation,
            this.toolStripSeparator7,
            this.toolStripSeparator8});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // btnAddLayer
            // 
            this.btnAddLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnAddLayer, "btnAddLayer");
            this.btnAddLayer.Name = "btnAddLayer";
            this.btnAddLayer.Click += new System.EventHandler(this.btnAddLayer_Click);
            // 
            // btnRemoveLayer
            // 
            this.btnRemoveLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnRemoveLayer, "btnRemoveLayer");
            this.btnRemoveLayer.Name = "btnRemoveLayer";
            this.btnRemoveLayer.Click += new System.EventHandler(this.btnRemoveLayer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // btnPan
            // 
            this.btnPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnPan, "btnPan");
            this.btnPan.Name = "btnPan";
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnZoomIn, "btnZoomIn");
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnZoomOut, "btnZoomOut");
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // btnCreateCutPolygon
            // 
            this.btnCreateCutPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnCreateCutPolygon, "btnCreateCutPolygon");
            this.btnCreateCutPolygon.Name = "btnCreateCutPolygon";
            this.btnCreateCutPolygon.Click += new System.EventHandler(this.btnCreateCutPolygon_Click);
            // 
            // btnCreateFillPolygon
            // 
            this.btnCreateFillPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnCreateFillPolygon, "btnCreateFillPolygon");
            this.btnCreateFillPolygon.Name = "btnCreateFillPolygon";
            this.btnCreateFillPolygon.Click += new System.EventHandler(this.btnCreateFillPolygon_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnViewElevation
            // 
            this.btnViewElevation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnViewElevation, "btnViewElevation");
            this.btnViewElevation.Name = "btnViewElevation";
            this.btnViewElevation.Click += new System.EventHandler(this.btnViewElevation_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtCutElevation);
            this.splitContainer1.Panel1.Controls.Add(this.cutElevation);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.spatialDockManager1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spatialStatusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.tabContainer.ResumeLayout(false);
            this.tabViewMap.ResumeLayout(false);
            this.spatialDockManager1.Panel1.ResumeLayout(false);
            this.spatialDockManager1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).EndInit();
            this.spatialDockManager1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl1)).EndInit();
            this.spatialStatusStrip1.ResumeLayout(false);
            this.spatialStatusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotSpatial.Controls.Map mapMain;
        private DotSpatial.Controls.AppManager appManager1;
        private System.Windows.Forms.TabControl tabContainer;
        private DotSpatial.Controls.Legend legMain;
        private DotSpatial.Controls.SpatialHeaderControl spatialHeaderControl1;
        private DotSpatial.Controls.SpatialDockManager spatialDockManager1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMain;
        private System.Windows.Forms.ToolStripMenuItem newProject;
        private System.Windows.Forms.ToolStripMenuItem saveProject;
        private System.Windows.Forms.ToolStripMenuItem saveAsProject;
        private System.Windows.Forms.ToolStripMenuItem openProject;
        private System.Windows.Forms.ToolStripMenuItem layersMain;
        private System.Windows.Forms.ToolStripMenuItem addLayerMenu;
        private System.Windows.Forms.ToolStripMenuItem removeLayerMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMain;
        private System.Windows.Forms.ToolStripMenuItem zoomInMenu;
        private System.Windows.Forms.ToolStripMenuItem zoomOutMenu;
        private System.Windows.Forms.ToolStripMenuItem panMenu;
        private System.Windows.Forms.ToolStripMenuItem insertMain;
        private System.Windows.Forms.ToolStripMenuItem createCutMenu;
        private System.Windows.Forms.ToolStripMenuItem viewElevationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFillMenu;
        private System.Windows.Forms.TabPage tabViewMap;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem zoomToExtentMenu;
        private System.Windows.Forms.ToolStripMenuItem caculatorMenu;
        private System.Windows.Forms.Label cutElevation;
        private System.Windows.Forms.TextBox txtCutElevation;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton btnPan;
        private System.Windows.Forms.ToolStripButton btnCreateCutPolygon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btnCreateFillPolygon;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel stax;
        private System.Windows.Forms.ToolStripStatusLabel stay;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnAddLayer;
        private System.Windows.Forms.ToolStripButton btnRemoveLayer;
        private System.Windows.Forms.ToolStripButton btnViewElevation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

