using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model.Deserializer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='GetNodeResponseDeserializer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/GetNodeResponseDeserializer", DoNotGenerateAcw=true)]
	public partial class GetNodeResponseDeserializer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='GetNodeResponseDeserializer.GetNodeResponseFieldDeserializer']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/GetNodeResponseDeserializer$GetNodeResponseFieldDeserializer", DoNotGenerateAcw=true)]
		public partial class GetNodeResponseFieldDeserializer : global::Com.Amazon.Clouddrive.Model.Deserializer.NodeDeserializer.NodeFieldDeserializer {

			protected GetNodeResponseFieldDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		protected GetNodeResponseDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
