// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoHotDraw.Database {
    
    
    public partial class ColorDialog {
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label2;
        
        private Gtk.ColorButton _colorButton;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoHotDraw.Database.ColorDialog
            this.Name = "MonoHotDraw.Database.ColorDialog";
            this.Title = Mono.Unix.Catalog.GetString("Select color");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.HasSeparator = false;
            // Internal child MonoHotDraw.Database.ColorDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Select color value:");
            this.hbox1.Add(this.label2);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.label2]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this._colorButton = new Gtk.ColorButton();
            this._colorButton.CanFocus = true;
            this._colorButton.Events = ((Gdk.EventMask)(784));
            this._colorButton.Name = "_colorButton";
            this.hbox1.Add(this._colorButton);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this._colorButton]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            w1.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(w1[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Internal child MonoHotDraw.Database.ColorDialog.ActionArea
            Gtk.HButtonBox w5 = this.ActionArea;
            w5.Name = "dialog1_ActionArea";
            w5.Spacing = 6;
            w5.BorderWidth = ((uint)(5));
            w5.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w6 = ((Gtk.ButtonBox.ButtonBoxChild)(w5[this.buttonCancel]));
            w6.Expand = false;
            w6.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w7 = ((Gtk.ButtonBox.ButtonBoxChild)(w5[this.buttonOk]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 202;
            this.DefaultHeight = 109;
            this.Show();
        }
    }
}