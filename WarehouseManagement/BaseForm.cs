using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Resources;
using Janus.Windows.GridEX;
using Janus.Windows.UI.CommandBars;
using Janus.Windows.EditControls;
using Janus.Windows.UI.Dock;
using Janus.Windows.UI.StatusBar;
using System.Collections;
using Janus.Windows.ExplorerBar;
using Janus.Windows.FilterEditor;

namespace WarehouseManagement
{
    public partial class BaseForm : Form
    {
        public MessageBoxControl _MsgBox;
        public ResourceManager resource = null;
        public string errorMsg = String.Empty;

        public delegate void ValidatorDelegate();
        public ValidatorDelegate InitValidator;
        public BaseForm()
        {
            InitializeComponent();
        }
        public string ShowMessage(string message, bool showYesNoButton)
        {
            this._MsgBox = new MessageBoxControl();
            this._MsgBox.ShowYesNoButton = showYesNoButton;
            this._MsgBox.MessageString = message;
            this._MsgBox.ShowDialog(this);
            string st = this._MsgBox.ReturnValue;
            _MsgBox.Dispose();
            return st;
        }
        public string ShowMessage(string message, bool showYesNoButton, bool showErrorButton, string exceptionString)
        {
            this._MsgBox = new MessageBoxControl();
            this._MsgBox.ShowErrorButton = showErrorButton;
            this._MsgBox.MessageString = message;
            this._MsgBox.exceptionString = exceptionString;
            this._MsgBox.ShowDialog(this);
            string st = this._MsgBox.ReturnValue;
            _MsgBox.Dispose();
            return st;
        }
        public string ShowMessage(string message, bool showYesNoButton, bool showErrorButton)
        {
            this._MsgBox = new MessageBoxControl();
            this._MsgBox.ShowErrorButton = showErrorButton;
            this._MsgBox.ShowYesNoButton = showYesNoButton;
            this._MsgBox.MessageString = message;
            this._MsgBox.ShowDialog(this);
            string st = this._MsgBox.ReturnValue;
            _MsgBox.Dispose();
            return st;
        }
        protected override void OnLoad(System.EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            if (Thread.CurrentThread.CurrentCulture.Equals(new CultureInfo("en-US")))
            {
                this.InitCulture("en-US", "WarehouseManagement.Resources.Language");
            }
            else
            {
                ResourceManager rm = new ResourceManager("WarehouseManagement.Resources.Language", typeof(BaseForm).Assembly);
                this.resource = rm;
            }

            base.OnLoad(e);
        }
        // Get all controls in form.
        public List<Control> GetAllControls(IList controls)
        {
            List<Control> allControls = new List<Control>();
            foreach (Control control in controls)
            {
                allControls.Add(control);
                List<Control> subControls = GetAllControls(control.Controls);
                allControls.AddRange(subControls);
            }

            return allControls;
        }
        public List<Component> GetAllComponent()
        {
            List<Component> allComponent = new List<Component>();
            int i = this.components.Components.Count;
            foreach (Component component in this.components.Components)
            {
                allComponent.Add(component);
            }
            //int j = this.
            return allComponent;
        }
        public void forGrid(Control c, ResourceManager rm, string formName)
        {
            GridEX grid = (GridEX)c;
            GridEXColumnCollection columnColl = grid.RootTable.Columns;
            string columnKey = "";
            string key = String.Empty;
            foreach (GridEXColumn column in columnColl)
            {
                try
                {
                    key = columnKey = "";
                    columnKey = column.Key;
                    key = formName + "_" + c.Name + "_" + columnKey;
                    if (rm.GetString(key) != null && rm.GetString(key).Trim().Length >= 1)
                    {
                        column.Caption = rm.GetString(key);
                    }
                }
                catch { }
            }
            if (grid.RootTable.Groups != null)
            {
                foreach (GridEXGroup group in grid.RootTable.Groups)
                {
                    try
                    {
                        key = "";
                        key = formName + "_" + grid.Name + "_group" + group.Index.ToString();
                        if (rm.GetString(key) != null && rm.GetString(key).Trim().Length >= 1)
                        {
                            group.HeaderCaption = rm.GetString(key);
                        }
                    }
                    catch { }
                }
            }
            if (grid.RootTable.ColumnSets != null)
            {
                foreach (GridEXColumnSet groupSet in grid.RootTable.ColumnSets)
                {
                    try
                    {
                        key = "";
                        key = formName + "_" + grid.Name + "_" + groupSet.Key;
                        if (rm.GetString(key) != null && rm.GetString(key).Trim().Length >= 1)
                        {
                            groupSet.Caption = rm.GetString(key);
                        }
                    }
                    catch { }
                }
            }
            if (grid.RootTable.GroupHeaderTotals != null)
            {
                foreach (GridEXGroupHeaderTotal groupHeaderTotal in grid.RootTable.GroupHeaderTotals)
                {
                    try
                    {
                        key = "";
                        key = formName + "_" + grid.Name + "_" + groupHeaderTotal.Key;
                        if (rm.GetString(key) != null && rm.GetString(key).Trim().Length >= 1)
                        {
                            groupHeaderTotal.TotalSuffix = rm.GetString(key);
                        }
                    }
                    catch { }
                }
            }
            if (grid.ContextMenuStrip != null)
            {
                forToolStripMenuItem(grid.ContextMenuStrip.Items, rm, formName, grid.ContextMenuStrip.Name);
            }
        }
        public void forToolStripMenuItem(ToolStripItemCollection itemColl, ResourceManager rm, string formName, string contextMenuName)
        {
            foreach (ToolStripMenuItem menuItem in itemColl)
            {
                try
                {
                    string key = "";
                    key = formName + "_" + contextMenuName + "_" + menuItem.Name;
                    if (rm.GetString(key) != null && rm.GetString(key).Trim().Length >= 1)
                    {
                        menuItem.Text = rm.GetString(key);

                    }
                }
                catch { }
                if (menuItem.DropDownItems != null && menuItem.DropDownItems.Count > 0) forToolStripMenuItem(menuItem.DropDownItems, rm, formName, contextMenuName);
            }
        }
        public List<UIPanelBase> getUIPanelChild(Janus.Windows.UI.Dock.UIPanelCollection panelColl, UIPanelGroup panelGroup)
        {
            List<UIPanelBase> allPanels = new List<UIPanelBase>();
            List<UIPanelBase> allPanels2 = new List<UIPanelBase>();
            if (panelColl != null)//coll
            {
                foreach (UIPanelGroup panelG in panelColl)
                {
                    string n = panelG.Name;
                    allPanels.Add(panelG);
                    getUIPanelChild(null, panelG);
                }
            }
            if (panelGroup != null)//group
            {
                if (panelGroup.Panels.Count > 0)
                {
                    for (int i = 0; i < (int)panelGroup.Panels.Count; i++)
                    {
                        if (panelGroup.Panels[i].GetType() == typeof(UIPanelGroup))
                        {
                            UIPanelGroup tmppanelGroup = (UIPanelGroup)panelGroup.Panels[i];
                            string n = tmppanelGroup.Name;
                            allPanels.Add(tmppanelGroup);
                            allPanels2 = this.getUIPanelChild(null, tmppanelGroup);
                            allPanels.AddRange(allPanels2);
                        }
                        else
                        {
                            string panelName = panelGroup.Panels[i].Name;
                            allPanels.Add(panelGroup.Panels[i]);
                        }
                    }
                }
            }
            return allPanels;
        }
        public List<UIPanelBase> getUIPanelChild2(Janus.Windows.UI.Dock.UIPanelCollection panelC, UIPanelGroup panelG)
        {
            List<UIPanelBase> allPanels = new List<UIPanelBase>();
            List<UIPanelBase> allPanels2 = new List<UIPanelBase>();
            UIPanelGroup panelGroup;
            if (panelC != null)//coll
            {
                panelGroup = (UIPanelGroup)panelC[0];
                allPanels.Add(panelGroup);
            }
            else
            {
                panelGroup = panelG;
            }
            string na = panelGroup.Name;
            if (panelGroup.Panels.Count > 0)
            {
                for (int i = 0; i < (int)panelGroup.Panels.Count; i++)
                {
                    if (panelGroup.Panels[i].GetType() == typeof(UIPanelGroup))
                    {
                        UIPanelGroup tmppanelGroup = (UIPanelGroup)panelGroup.Panels[i];
                        string n = tmppanelGroup.Name;
                        allPanels.Add(tmppanelGroup);
                        allPanels2 = this.getUIPanelChild(null, tmppanelGroup);
                        allPanels.AddRange(allPanels2);
                    }
                    else
                    {
                        string panelName = panelGroup.Panels[i].Name;
                        allPanels.Add(panelGroup.Panels[i]);
                    }
                }
            }
            return allPanels;
        }
        public void forPanel(Component c, ResourceManager rm, string formName)
        {
            if (c.GetType().ToString().Contains("PanelManager"))
            {
                Janus.Windows.UI.Dock.UIPanelManager p = (Janus.Windows.UI.Dock.UIPanelManager)c;
                Janus.Windows.UI.Dock.UIPanelCollection panelColl = p.Panels;
                List<UIPanelBase> panels = getUIPanelChild2(panelColl, null);
                foreach (Janus.Windows.UI.Dock.UIPanelBase panel in panels)
                {
                    try
                    {
                        string panelName = panel.Name;
                        string panelText = panel.Text;
                        string key = formName + "_" + panelName;
                        if (rm.GetString(key) != null && rm.GetString(key).Trim() != "")
                        {
                            panel.Text = rm.GetString(key);
                        }
                    }
                    catch { }
                }

            }
            else
            {

            }

        }// no need
        public void forExplore(Component c, ResourceManager rm, string formName)
        {

            ExplorerBar e = (ExplorerBar)c;
            string eName = e.Name;
            foreach (ExplorerBarGroup eGroup in e.Groups)
            {
                string groupKey = eGroup.Key;
                try
                {

                    if (rm.GetString(formName + "_" + groupKey) != null && rm.GetString(formName + "_" + groupKey).Trim() != "")
                    {
                        eGroup.Text = rm.GetString(formName + "_" + groupKey);
                    }
                }
                catch { }
                foreach (ExplorerBarItem eItem in eGroup.Items)
                {
                    try
                    {
                        string itemKey = eItem.Key;
                        string key = formName + "_" + groupKey + "_" + itemKey;
                        if (rm.GetString(key) != null && rm.GetString(key).Trim() != "")
                        {
                            eItem.Text = rm.GetString(key);
                        }
                    }
                    catch { }

                }


            }
        }
        public List<UICommand> forCommandBar(Control c, UICommand cm, ResourceManager rm, string formName)
        {
            List<UICommand> allCommand = new List<UICommand>();
            List<UICommand> suballCommand = new List<UICommand>();
            UICommandBar cmdBar = (UICommandBar)c;
            if (c != null)
            {
                //contextMenu
                UICommandManager cmdMangager = cmdBar.CommandManager;
                UIContextMenuCollection contextMenuColl = cmdMangager.ContextMenus;
                if (contextMenuColl != null)
                {
                    for (int i = 0; i < cmdMangager.ContextMenus.Count; i++)
                    {
                        UICommandCollection cmdColl = cmdMangager.ContextMenus[i].Commands;
                        if (cmdColl != null && cmdColl.Count > 0)
                        {
                            foreach (UICommand cmd in cmdColl)
                            {
                                try
                                {
                                    string key = formName + "_" + cmd.Key;
                                    if (rm.GetString(key) != null && rm.GetString(key).Trim() != "")
                                    {
                                        cmd.Text = rm.GetString(key);
                                    }
                                }
                                catch { }
                            }
                        }
                    }
                }
                //if (cmdMangager.Commands != null)
                //{
                //    foreach (UICommand cmd in cmdMangager.Commands)
                //    {
                //        string key = formName + "_" + cmd.Key;
                //        if (rm.GetString(key) != null && rm.GetString(key).Trim() != "")
                //        {
                //            cmd.Text = rm.GetString(key);

                //        }
                //    }

                //}
                //Command
                string cmdBarKey = cmdBar.Name;
                foreach (UICommand cmd in cmdBar.Commands)
                {
                    try
                    {
                        string cmdKey = cmd.Key;
                        if (rm.GetString(formName + "_" + cmdKey) != null && rm.GetString(formName + "_" + cmdKey).Trim() != "")
                        {
                            cmd.Text = rm.GetString(formName + "_" + cmdKey);
                        }
                    }
                    catch { }
                    if (cmd.Commands.Count > 0)
                    {
                        suballCommand = forCommandBar(null, cmd, rm, formName);
                        allCommand.AddRange(suballCommand);
                    }
                    else
                    {
                        allCommand.Add(cmd);
                    }
                }
            }
            if (cm != null)
            {
                string cmdKey = cm.Key;
                allCommand.Add(cm);
                foreach (UICommand cmd in cm.Commands)
                {
                    try
                    {
                        string Key = cmd.Key;
                        //cmd.Text;
                        if (rm.GetString(formName + "_" + Key) != null && rm.GetString(formName + "_" + Key) != "")
                        {
                            cmd.Text = rm.GetString(formName + "_" + Key);
                        }
                        if (cmd.Commands.Count > 0)
                        {
                            suballCommand = forCommandBar(null, cmd, rm, formName);
                            allCommand.AddRange(suballCommand);
                        }
                        else
                        {
                            allCommand.Add(cmd);
                        }
                    }
                    catch { }
                }
            }
            return allCommand;

        }
        public void forChildControlInpanel(UIPanelBase panel, ResourceManager rm, string formname)
        {
            if (panel.GetType() == typeof(UIPanelGroup))
            {
                UIPanelGroup panelG = (UIPanelGroup)panel;
                foreach (UIPanelBase pBase in panelG.Panels)
                {
                    forChildControlInpanel(pBase, rm, formname);
                }
            }
            else//UIPanel
            {
                string key = String.Empty;
                key = panel.Name;
                key = "";
                Control tmpCtr = panel.GetNextControl(new Control(), true);
                if (tmpCtr.GetType() == typeof(UIPanelInnerContainer))
                {
                    UIPanelInnerContainer panelContainer = (UIPanelInnerContainer)tmpCtr;
                    if (panelContainer.Controls != null && panelContainer.Controls.Count > 0)
                    {
                        foreach (Control control in panelContainer.Controls)
                        {
                            // Label
                            if (control.GetType() == typeof(GridEX))
                            {
                                this.forGrid(control, rm, formname);
                            }
                            else if (control.GetType() == typeof(UIPanel))//UIpanel
                            {
                                if (panel.Name == control.Name) { }
                                key = String.Empty;
                                key = formname + "_" + panel.Name;
                                try
                                {
                                    if (rm.GetString(key) != null && rm.GetString(key) != "")
                                    {
                                        control.Text = rm.GetString(key);
                                    }
                                }
                                catch
                                {
                                }
                            }
                            else //UIGroupBox
                            {
                                UIGroupBox group = (UIGroupBox)control;
                                if (group.HasChildren)
                                {
                                }
                            }
                        }
                    }
                }
                else//UiPanel 
                {
                    forChildControlInpanel((UIPanel)tmpCtr, rm, formname);
                }
            }

        }
        // Init culture and language.
        public void InitCulture(string language, string resourcefile)
        {
            CultureInfo culture = new CultureInfo(language);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            // Init control:
            ResourceManager rm = new ResourceManager(resourcefile, typeof(BaseForm).Assembly);
            this.resource = rm;
            List<Control> allControls = GetAllControls(this.Controls);
            if (this.components != null)
            {
                List<Component> allComponents = this.GetAllComponent();
            }

            int i = allControls.Count;
            string name = "";
            string key = "";
            foreach (Control c in allControls)
            {
                Form f = c.FindForm();

                Type ctrType = c.GetType();
                // if (ctrTypeName == "Janus.Window.GridEX.GridEX" )                
                if (ctrType == typeof(GridEX))
                {
                    this.forGrid(c, rm, f.Name);
                }
                else if (ctrType == typeof(Janus.Windows.ExplorerBar.ExplorerBar))
                {
                    this.forExplore(c, rm, f.Name);
                }
                else if (c.GetType() == typeof(UICommandBar))
                {
                    List<UICommand> cmdList = this.forCommandBar(c, null, rm, f.Name);
                }
                else if (c.GetType() == typeof(ContextMenuStrip))
                {

                }

                else if (c.GetType() == typeof(UIComboBox))
                {
                    UIComboBox cbo = (UIComboBox)c;
                    if (cbo.Items.Count > 0 && cbo.ValueMember == "")
                    {
                        foreach (UIComboBoxItem item in cbo.Items)
                        {
                            key = "";
                            string text = item.Text.ToString();
                            key = text;
                            switch (key.Trim())
                            {
                                case "Chưa khai báo": 
                                    key = "status_No_Declared"; 
                                    break;
                            }
                            try
                            {
                                if (rm.GetString(key) != null && rm.GetString(key).Trim().Length >= 1)
                                {
                                    item.Text = rm.GetString(key);
                                }
                            }
                            catch { }

                        }

                    }

                }
                //else
                    //if (c.GetType() == typeof(FilterEditor))
                    //{
                    //FilterEditor filter = (FilterEditor)c;
                    //key = "";
                    //string columnKey = "";
                    //Janus.Windows.GridEX.GridEX grid = (Janus.Windows.GridEX.GridEX)filter.SourceControl;
                    //foreach (GridEXColumn column in filter.Table.Fields)
                    //{
                    //    try
                    //    {
                    //        key = columnKey = "";
                    //        columnKey = column.Key;
                    //        key = f.Name + "_" + grid.Name + "_" + columnKey;
                    //        if (rm.GetString(key) != null && rm.GetString(key).Trim().Length >= 1)
                    //        {
                    //            column.Caption = rm.GetString(key);
                    //        }
                    //    }
                    //    catch { }
                    //}
                    ////filter.Refresh();
                    //filter.Reload();

                //}
                else if (c.GetType() == typeof(UIAutoHideStrip))
                {
                    UIAutoHideStrip hideCtr = (UIAutoHideStrip)c;
                    UIPanelBase[] panelbase = hideCtr.Panels;
                    foreach (UIPanelBase panel in panelbase)
                    {
                        try
                        {
                            key = String.Empty;
                            key = f.Name + "_" + panel.Name;
                            key = key.Trim();

                            if (rm.GetString(key) != null && rm.GetString(key).Length >= 1)
                            {
                                panel.Text = rm.GetString(key);
                            }

                            if (panel.HasChildren)
                            {
                                forChildControlInpanel((UIPanelBase)panel, rm, f.Name);
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                else if (c.GetType() == typeof(UIStatusBar))
                {
                    UIStatusBar statusBar = (UIStatusBar)c;
                    if (statusBar.Panels != null)
                    {
                        foreach (UIStatusBarPanel statusP in statusBar.Panels)
                        {
                            try
                            {
                                key = "";
                                key = f.Name + "_" + c.Name + "_" + statusP.Key;
                                if (rm.GetString(key) != null && rm.GetString(key).Trim() != "")
                                {
                                    statusP.Text = statusP.ToolTipText = rm.GetString(key);

                                }
                            }
                            catch { }
                        }
                    }
                }
                else
                {
                    key = String.Empty;
                    if (c.Name.Trim() != "")
                    {
                        key = f.Name + "_" + c.Name;
                        try
                        {
                            if (rm.GetString(key) != null && rm.GetString(key).Trim() != "") { c.Text = rm.GetString(key); }
                        }
                        catch(Exception ex)
                        {
                            Logger.LocalLogger.Instance().WriteMessage(ex);
                        }
                    }
                }
            }
            // Init form title:                 
            try
            {
                string text = this.Name.Trim();
                if (rm.GetString(text) != null && rm.GetString(text).Trim() != "")
                {
                    this.Text = rm.GetString(text);
                }
            }
            catch
            {
            }
            //if (ValidatorManager.GetValidators(this) != null)
            //{
            //    foreach (BaseValidator baseVali in ValidatorManager.GetValidators(this))
            //    {
            //        try
            //        {
            //            baseVali.ErrorMessage = rm.GetString(this.Name + "_" + baseVali.Tag);
            //            baseVali.ErrorMessageEnglish = rm.GetString(this.Name + "_" + baseVali.Tag);
            //            string st = baseVali.ErrorMessage;
            //        }
            //        catch { }
            //    }
            //}
        }
    }
}
