using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model.Deserializer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='CreateNodeResponseDeserializer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/CreateNodeResponseDeserializer", DoNotGenerateAcw=true)]
	public partial class CreateNodeResponseDeserializer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='CreateNodeResponseDeserializer.CreateNodeResponseFieldDeserializer']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/CreateNodeResponseDeserializer$CreateNodeResponseFieldDeserializer", DoNotGenerateAcw=true)]
		public partial class CreateNodeResponseFieldDeserializer : global::Com.Amazon.Clouddrive.Model.Deserializer.NodeDeserializer.NodeFieldDeserializer {

			protected CreateNodeResponseFieldDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		protected CreateNodeResponseDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
