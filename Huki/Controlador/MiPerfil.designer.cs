// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Huki
{
	[Register ("MiPerfil")]
	partial class MiPerfil
	{
		[Outlet]
		UIKit.UIImageView Imagen { get; set; }

		[Outlet]
		UIKit.UITableViewCell ImageRow { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ImageRow != null) {
				ImageRow.Dispose ();
				ImageRow = null;
			}

			if (Imagen != null) {
				Imagen.Dispose ();
				Imagen = null;
			}
		}
	}
}
