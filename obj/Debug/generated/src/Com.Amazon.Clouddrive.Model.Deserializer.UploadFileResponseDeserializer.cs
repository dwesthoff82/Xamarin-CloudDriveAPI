using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model.Deserializer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='UploadFileResponseDeserializer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/UploadFileResponseDeserializer", DoNotGenerateAcw=true)]
	public partial class UploadFileResponseDeserializer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='UploadFileResponseDeserializer.UploadFileResponseFieldDeserializer']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/UploadFileResponseDeserializer$UploadFileResponseFieldDeserializer", DoNotGenerateAcw=true)]
		public partial class UploadFileResponseFieldDeserializer : global::Com.Amazon.Clouddrive.Model.Deserializer.NodeDeserializer.NodeFieldDeserializer {

			protected UploadFileResponseFieldDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		protected UploadFileResponseDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
