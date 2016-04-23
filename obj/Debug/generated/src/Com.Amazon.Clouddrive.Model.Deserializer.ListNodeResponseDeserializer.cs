using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model.Deserializer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='ListNodeResponseDeserializer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/ListNodeResponseDeserializer", DoNotGenerateAcw=true)]
	public partial class ListNodeResponseDeserializer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='ListNodeResponseDeserializer.ListNodeResponseFieldDeserializer']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/ListNodeResponseDeserializer$ListNodeResponseFieldDeserializer", DoNotGenerateAcw=true)]
		public partial class ListNodeResponseFieldDeserializer : global::Com.Amazon.Clouddrive.Model.Deserializer.PaginatedCloudDriveResponseFieldDeserializer {

			protected ListNodeResponseFieldDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		protected ListNodeResponseDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
