using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model.Deserializer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='ListTrashResponseDeserializer']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/ListTrashResponseDeserializer", DoNotGenerateAcw=true)]
	public partial class ListTrashResponseDeserializer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model.deserializer']/class[@name='ListTrashResponseDeserializer.ListNodesInTrashResponseFieldDeserializer']"
		[global::Android.Runtime.Register ("com/amazon/clouddrive/model/deserializer/ListTrashResponseDeserializer$ListNodesInTrashResponseFieldDeserializer", DoNotGenerateAcw=true)]
		public partial class ListNodesInTrashResponseFieldDeserializer : global::Com.Amazon.Clouddrive.Model.Deserializer.PaginatedCloudDriveResponseFieldDeserializer {

			protected ListNodesInTrashResponseFieldDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		protected ListTrashResponseDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
