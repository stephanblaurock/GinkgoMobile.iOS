using System;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Xamarin.Forms;
using Foundation;
using Ginkgo.Views;
using Ginkgo.iOS.Renderer;

[assembly: ExportRenderer(typeof(CustomTimePicker24H), typeof(CustomTimePicker24HRenderer))]
namespace Ginkgo.iOS.Renderer {
	public class CustomTimePicker24HRenderer : TimePickerRenderer {
		protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e) {
			base.OnElementChanged(e);
			var timePicker = (UIDatePicker)Control.InputView;
			timePicker.Locale = new NSLocale("no_nb");
			if (Control != null) {
				Control.Text = DateTime.Now.ToString("HH:mm");
			}
		}
	}

}
