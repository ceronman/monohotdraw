// MonoDevelop ClassDesigner
//
// Authors:
//	Manuel Cerón <ceronman@gmail.com>
//
// Copyright (C) 2009 Manuel Cerón
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Text;
using Gtk;
using MonoDevelop.Core;
using MonoDevelop.Ide.Gui;
using MonoHotDraw;
using MonoHotDraw.Tools;
using MonoDevelop.ClassDesigner.Figures;

namespace MonoDevelop.ClassDesigner {
	
	public class ClassDesignerView: AbstractViewContent {
		
		public override string StockIconId {
			get {
				return Stock.Convert;
			}
		}
		
		public override void Load (string fileName)
		{
		}
		
		public override bool IsFile {
			get {
				return false;
			}
		}
		
		public override Widget Control {
			get {
				return mhdEditor;
			}
		}

		public ClassDesignerView()
		{
			ContentName = GettextCatalog.GetString ("Class Diagram");
			IsViewOnly = true;
			mhdEditor = new SteticComponent();
			mhdEditor.ShowAll();
			TypeHeaderFigure figure = new TypeHeaderFigure();
			mhdEditor.View.Drawing.Add(figure);
			figure.MoveTo(10.0, 10.0);
		}
		
		private SteticComponent mhdEditor;
	}
}
