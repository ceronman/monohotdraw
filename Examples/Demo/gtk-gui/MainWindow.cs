// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.UIManager UIManager;
    
    private Gtk.Action FiguresAction;
    
    private Gtk.Action AddEllipseAction;
    
    private Gtk.Action AddRectangleAction;
    
    private Gtk.Action AddPolyLineAction;
    
    private Gtk.Action AddSimpleTextAction;
    
    private Gtk.Action AddMultiLineTextAction;
    
    private Gtk.Action AddLineConnectionAction;
    
    private Gtk.Action EditAction;
    
    private Gtk.Action UndoAction;
    
    private Gtk.Action RedoAction;
    
    private Gtk.VBox vbox1;
    
    private Gtk.MenuBar menubar1;
    
    private MonoHotDraw.SteticComponent mhdcanvas;
    
    private Gtk.HBox hbox1;
    
    private Gtk.HBox hbox2;
    
    private Gtk.Label label2;
    
    private Gtk.HScale zoomscale;
    
    private Gtk.Label label3;
    
    private Gtk.Label visiblearea;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.UIManager = new Gtk.UIManager();
        Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
        this.FiguresAction = new Gtk.Action("FiguresAction", Mono.Unix.Catalog.GetString("Figures"), null, null);
        this.FiguresAction.ShortLabel = Mono.Unix.Catalog.GetString("Figures");
        w1.Add(this.FiguresAction, null);
        this.AddEllipseAction = new Gtk.Action("AddEllipseAction", Mono.Unix.Catalog.GetString("Add Ellipse"), null, null);
        this.AddEllipseAction.ShortLabel = Mono.Unix.Catalog.GetString("Add Ellipse");
        w1.Add(this.AddEllipseAction, null);
        this.AddRectangleAction = new Gtk.Action("AddRectangleAction", Mono.Unix.Catalog.GetString("Add Rectangle"), null, null);
        this.AddRectangleAction.ShortLabel = Mono.Unix.Catalog.GetString("Add Rectangle");
        w1.Add(this.AddRectangleAction, null);
        this.AddPolyLineAction = new Gtk.Action("AddPolyLineAction", Mono.Unix.Catalog.GetString("Add PolyLine"), null, null);
        this.AddPolyLineAction.ShortLabel = Mono.Unix.Catalog.GetString("Add PolyLine");
        w1.Add(this.AddPolyLineAction, null);
        this.AddSimpleTextAction = new Gtk.Action("AddSimpleTextAction", Mono.Unix.Catalog.GetString("Add SimpleText"), null, null);
        this.AddSimpleTextAction.ShortLabel = Mono.Unix.Catalog.GetString("Add SimpleText");
        w1.Add(this.AddSimpleTextAction, null);
        this.AddMultiLineTextAction = new Gtk.Action("AddMultiLineTextAction", Mono.Unix.Catalog.GetString("Add MultiLineText"), null, null);
        this.AddMultiLineTextAction.ShortLabel = Mono.Unix.Catalog.GetString("Add MultiLineText");
        w1.Add(this.AddMultiLineTextAction, null);
        this.AddLineConnectionAction = new Gtk.Action("AddLineConnectionAction", Mono.Unix.Catalog.GetString("Add LineConnection"), null, null);
        this.AddLineConnectionAction.ShortLabel = Mono.Unix.Catalog.GetString("Add LineConnection");
        w1.Add(this.AddLineConnectionAction, null);
        this.EditAction = new Gtk.Action("EditAction", Mono.Unix.Catalog.GetString("Edit"), null, null);
        this.EditAction.ShortLabel = Mono.Unix.Catalog.GetString("Edit");
        w1.Add(this.EditAction, null);
        this.UndoAction = new Gtk.Action("UndoAction", Mono.Unix.Catalog.GetString("_Deshacer"), null, "gtk-undo");
        this.UndoAction.ShortLabel = Mono.Unix.Catalog.GetString("_Deshacer");
        w1.Add(this.UndoAction, "<Control>z");
        this.RedoAction = new Gtk.Action("RedoAction", Mono.Unix.Catalog.GetString("_Rehacer"), null, "gtk-redo");
        this.RedoAction.ShortLabel = Mono.Unix.Catalog.GetString("_Rehacer");
        w1.Add(this.RedoAction, "<Control>y");
        this.UIManager.InsertActionGroup(w1, 0);
        this.AddAccelGroup(this.UIManager.AccelGroup);
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("MainWindow");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FiguresAction' action='FiguresAction'><menuitem name='AddEllipseAction' action='AddEllipseAction'/><menuitem name='AddRectangleAction' action='AddRectangleAction'/><menuitem name='AddPolyLineAction' action='AddPolyLineAction'/><menuitem name='AddSimpleTextAction' action='AddSimpleTextAction'/><menuitem name='AddMultiLineTextAction' action='AddMultiLineTextAction'/><menuitem name='AddLineConnectionAction' action='AddLineConnectionAction'/></menu><menu name='EditAction' action='EditAction'><menuitem name='UndoAction' action='UndoAction'/><menuitem name='RedoAction' action='RedoAction'/></menu></menubar></ui>");
        this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
        this.menubar1.Name = "menubar1";
        this.vbox1.Add(this.menubar1);
        Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
        w2.Position = 0;
        w2.Expand = false;
        w2.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.mhdcanvas = new MonoHotDraw.SteticComponent();
        this.mhdcanvas.Events = ((Gdk.EventMask)(256));
        this.mhdcanvas.Name = "mhdcanvas";
        this.vbox1.Add(this.mhdcanvas);
        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.mhdcanvas]));
        w3.Position = 1;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox1 = new Gtk.HBox();
        this.hbox1.Name = "hbox1";
        this.hbox1.Spacing = 6;
        // Container child hbox1.Gtk.Box+BoxChild
        this.hbox2 = new Gtk.HBox();
        this.hbox2.Name = "hbox2";
        this.hbox2.Spacing = 6;
        // Container child hbox2.Gtk.Box+BoxChild
        this.label2 = new Gtk.Label();
        this.label2.Name = "label2";
        this.label2.LabelProp = Mono.Unix.Catalog.GetString("Zoom:");
        this.hbox2.Add(this.label2);
        Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox2[this.label2]));
        w4.Position = 0;
        w4.Expand = false;
        w4.Fill = false;
        // Container child hbox2.Gtk.Box+BoxChild
        this.zoomscale = new Gtk.HScale(null);
        this.zoomscale.CanFocus = true;
        this.zoomscale.Name = "zoomscale";
        this.zoomscale.Adjustment.Lower = 10;
        this.zoomscale.Adjustment.Upper = 500;
        this.zoomscale.Adjustment.PageIncrement = 50;
        this.zoomscale.Adjustment.StepIncrement = 1;
        this.zoomscale.Adjustment.Value = 100;
        this.zoomscale.DrawValue = true;
        this.zoomscale.Digits = 0;
        this.zoomscale.ValuePos = ((Gtk.PositionType)(3));
        this.hbox2.Add(this.zoomscale);
        Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox2[this.zoomscale]));
        w5.Position = 1;
        // Container child hbox2.Gtk.Box+BoxChild
        this.label3 = new Gtk.Label();
        this.label3.Name = "label3";
        this.label3.LabelProp = Mono.Unix.Catalog.GetString("Visible Area:");
        this.hbox2.Add(this.label3);
        Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox2[this.label3]));
        w6.Position = 2;
        w6.Expand = false;
        w6.Fill = false;
        this.hbox1.Add(this.hbox2);
        Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox1[this.hbox2]));
        w7.Position = 0;
        // Container child hbox1.Gtk.Box+BoxChild
        this.visiblearea = new Gtk.Label();
        this.visiblearea.Name = "visiblearea";
        this.visiblearea.LabelProp = Mono.Unix.Catalog.GetString("~");
        this.hbox1.Add(this.visiblearea);
        Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox1[this.visiblearea]));
        w8.Position = 1;
        w8.Expand = false;
        w8.Fill = false;
        this.vbox1.Add(this.hbox1);
        Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
        w9.Position = 2;
        w9.Expand = false;
        this.Add(this.vbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 446;
        this.DefaultHeight = 300;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.AddEllipseAction.Activated += new System.EventHandler(this.OnAddEllipseActionActivated);
        this.AddRectangleAction.Activated += new System.EventHandler(this.OnAddRectangleActionActivated);
        this.AddPolyLineAction.Activated += new System.EventHandler(this.OnAddPolyLineActionActivated);
        this.AddSimpleTextAction.Activated += new System.EventHandler(this.OnAddSimpleTextActionActivated);
        this.AddMultiLineTextAction.Activated += new System.EventHandler(this.OnAddMultiLineTextActionActivated);
        this.AddLineConnectionAction.Activated += new System.EventHandler(this.OnAddLineConnectionActionActivated);
        this.UndoAction.Activated += new System.EventHandler(this.OnUndoActionActivated);
        this.RedoAction.Activated += new System.EventHandler(this.OnRedoActionActivated);
        this.zoomscale.ValueChanged += new System.EventHandler(this.OnHscale1ValueChanged);
    }
}
