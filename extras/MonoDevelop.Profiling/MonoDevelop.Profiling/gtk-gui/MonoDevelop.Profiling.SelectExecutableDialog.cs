
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Profiling
{
	public partial class SelectExecutableDialog
	{
		private global::Gtk.Table table;

		private global::Gtk.Button buttonOpen;

		private global::Gtk.ComboBox comboProfilers;

		private global::Gtk.Entry entryArguments;

		private global::Gtk.Entry entryExecutable;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Profiling.SelectExecutableDialog
			this.Name = "MonoDevelop.Profiling.SelectExecutableDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Select Executable");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoDevelop.Profiling.SelectExecutableDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.table.Name = "table";
			this.table.RowSpacing = ((uint)(6));
			this.table.ColumnSpacing = ((uint)(6));
			// Container child table.Gtk.Table+TableChild
			this.buttonOpen = new global::Gtk.Button ();
			this.buttonOpen.CanFocus = true;
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.UseStock = true;
			this.buttonOpen.UseUnderline = true;
			this.buttonOpen.Label = "gtk-open";
			this.table.Add (this.buttonOpen);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table[this.buttonOpen]));
			w2.LeftAttach = ((uint)(2));
			w2.RightAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.comboProfilers = global::Gtk.ComboBox.NewText ();
			this.comboProfilers.Name = "comboProfilers";
			this.table.Add (this.comboProfilers);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table[this.comboProfilers]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(3));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.entryArguments = new global::Gtk.Entry ();
			this.entryArguments.CanFocus = true;
			this.entryArguments.Name = "entryArguments";
			this.entryArguments.IsEditable = true;
			this.entryArguments.InvisibleChar = '●';
			this.table.Add (this.entryArguments);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table[this.entryArguments]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(3));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.entryExecutable = new global::Gtk.Entry ();
			this.entryExecutable.CanFocus = true;
			this.entryExecutable.Name = "entryExecutable";
			this.entryExecutable.IsEditable = true;
			this.entryExecutable.InvisibleChar = '●';
			this.table.Add (this.entryExecutable);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table[this.entryExecutable]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0f;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Executable");
			this.table.Add (this.label1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table[this.label1]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0f;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Arguments");
			this.table.Add (this.label2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table[this.label2]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0f;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Profiler");
			this.table.Add (this.label3);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table[this.label3]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.table);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(w1[this.table]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Internal child MonoDevelop.Profiling.SelectExecutableDialog.ActionArea
			global::Gtk.HButtonBox w10 = this.ActionArea;
			w10.Name = "dialog1_ActionArea";
			w10.Spacing = 6;
			w10.BorderWidth = ((uint)(5));
			w10.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonCancel]));
			w11.Expand = false;
			w11.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.Sensitive = false;
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonOk]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 488;
			this.DefaultHeight = 185;
			this.Show ();
			this.entryExecutable.Changed += new global::System.EventHandler (this.ExecutableChanged);
			this.buttonOpen.Clicked += new global::System.EventHandler (this.OpenClicked);
		}
	}
}