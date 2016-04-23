using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model.Deserializer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='UpdateNodeResponseDeserializer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/UpdateNodeResponseDeserializer", DoNotGenerateAcw=true)]
	public partial class UpdateNodeResponseDeserializer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='UpdateNodeResponseDeserializer.UpdateNodeResponseFieldDeserializer']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/UpdateNodeResponseDeserializer$UpdateNodeResponseFieldDeserializer", DoNotGenerateAcw=true)]
		public partial class UpdateNodeResponseFieldDeserializer : global::Com.Amazon.Clouddrive.Model.Deserializer.NodeDeserializer.NodeFieldDeserializer {

			protected UpdateNodeResponseFieldDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		protected UpdateNodeResponseDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
