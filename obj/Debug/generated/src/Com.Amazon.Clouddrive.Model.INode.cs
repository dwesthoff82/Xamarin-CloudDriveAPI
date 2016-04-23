using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']"
	[Register ("com/amazon/clouddrive/model/INode", "", "Com.Amazon.Clouddrive.Model.INodeInvoker")]
	public partial interface INode : global::Com.Amazon.Clouddrive.Model.IEditableNode {

		global::System.Collections.Generic.IList<global::Com.Amazon.Clouddrive.Model.Node> Assets {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='getAssets' and count(parameter)=0]"
			[Register ("getAssets", "()Ljava/util/List;", "GetGetAssetsHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setAssets' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.amazon.clouddrive.model.Node&gt;']]"
			[Register ("setAssets", "(Ljava/util/List;)V", "GetSetAssets_Ljava_util_List_Handler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] set;
		}

		string CreatedBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='getCreatedBy' and count(parameter)=0]"
			[Register ("getCreatedBy", "()Ljava/lang/String;", "GetGetCreatedByHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setCreatedBy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCreatedBy", "(Ljava/lang/String;)V", "GetSetCreatedBy_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] set;
		}

		string CreatedDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='getCreatedDate' and count(parameter)=0]"
			[Register ("getCreatedDate", "()Ljava/lang/String;", "GetGetCreatedDateHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setCreatedDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCreatedDate", "(Ljava/lang/String;)V", "GetSetCreatedDate_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] set;
		}

		string ETagRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='getETagRequest' and count(parameter)=0]"
			[Register ("getETagRequest", "()Ljava/lang/String;", "GetGetETagRequestHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setETagRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setETagRequest", "(Ljava/lang/String;)V", "GetSetETagRequest_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] set;
		}

		string ETagResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='getETagResponse' and count(parameter)=0]"
			[Register ("getETagResponse", "()Ljava/lang/String;", "GetGetETagResponseHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setETagResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setETagResponse", "(Ljava/lang/String;)V", "GetSetETagResponse_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] set;
		}

		string ModifiedDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='getModifiedDate' and count(parameter)=0]"
			[Register ("getModifiedDate", "()Ljava/lang/String;", "GetGetModifiedDateHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setModifiedDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setModifiedDate", "(Ljava/lang/String;)V", "GetSetModifiedDate_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] set;
		}

		string TempLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='getTempLink' and count(parameter)=0]"
			[Register ("getTempLink", "()Ljava/lang/String;", "GetGetTempLinkHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setTempLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTempLink", "(Ljava/lang/String;)V", "GetSetTempLink_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] set;
		}

		long Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()J", "GetGetVersionHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setVersion", "(J)V", "GetSetVersion_JHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='isExclusivelyTrashed' and count(parameter)=0]"
		[Register ("isExclusivelyTrashed", "()Ljava/lang/Boolean;", "GetIsExclusivelyTrashedHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")]
		global::Java.Lang.Boolean IsExclusivelyTrashed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='isRecursivelyTrashed' and count(parameter)=0]"
		[Register ("isRecursivelyTrashed", "()Ljava/lang/Boolean;", "GetIsRecursivelyTrashedHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")]
		global::Java.Lang.Boolean IsRecursivelyTrashed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='isRoot' and count(parameter)=0]"
		[Register ("isRoot", "()Ljava/lang/Boolean;", "GetIsRootHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")]
		global::Java.Lang.Boolean IsRoot ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='isShared' and count(parameter)=0]"
		[Register ("isShared", "()Ljava/lang/Boolean;", "GetIsSharedHandler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")]
		global::Java.Lang.Boolean IsShared ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setExclusivelyTrashed' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setExclusivelyTrashed", "(Ljava/lang/Boolean;)V", "GetSetExclusivelyTrashed_Ljava_lang_Boolean_Handler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")]
		void SetExclusivelyTrashed (global::Java.Lang.Boolean p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setIsRoot' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setIsRoot", "(Ljava/lang/Boolean;)V", "GetSetIsRoot_Ljava_lang_Boolean_Handler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")]
		void SetIsRoot (global::Java.Lang.Boolean p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setIsShared' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setIsShared", "(Ljava/lang/Boolean;)V", "GetSetIsShared_Ljava_lang_Boolean_Handler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")]
		void SetIsShared (global::Java.Lang.Boolean p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='INode']/method[@name='setRecursivelyTrashed' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setRecursivelyTrashed", "(Ljava/lang/Boolean;)V", "GetSetRecursivelyTrashed_Ljava_lang_Boolean_Handler:Com.Amazon.Clouddrive.Model.INodeInvoker, CloudDriveAPI")]
		void SetRecursivelyTrashed (global::Java.Lang.Boolean p0);

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/INode", DoNotGenerateAcw=true)]
	internal class INodeInvoker : global::Java.Lang.Object, INode {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/clouddrive/model/INode");
		IntPtr class_ref;

		public static INode GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INode> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.clouddrive.model.INode"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INodeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INodeInvoker); }
		}

		static Delegate cb_getAssets;
#pragma warning disable 0169
		static Delegate GetGetAssetsHandler ()
		{
			if (cb_getAssets == null)
				cb_getAssets = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAssets);
			return cb_getAssets;
		}

		static IntPtr n_GetAssets (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.ToLocalJniHandle (__this.Assets);
		}
#pragma warning restore 0169

		static Delegate cb_setAssets_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAssets_Ljava_util_List_Handler ()
		{
			if (cb_setAssets_Ljava_util_List_ == null)
				cb_setAssets_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAssets_Ljava_util_List_);
			return cb_setAssets_Ljava_util_List_;
		}

		static void n_SetAssets_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Assets = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAssets;
		IntPtr id_setAssets_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Amazon.Clouddrive.Model.Node> Assets {
			get {
				if (id_getAssets == IntPtr.Zero)
					id_getAssets = JNIEnv.GetMethodID (class_ref, "getAssets", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAssets), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAssets_Ljava_util_List_ == IntPtr.Zero)
					id_setAssets_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAssets", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setAssets_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getCreatedBy;
#pragma warning disable 0169
		static Delegate GetGetCreatedByHandler ()
		{
			if (cb_getCreatedBy == null)
				cb_getCreatedBy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedBy);
			return cb_getCreatedBy;
		}

		static IntPtr n_GetCreatedBy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreatedBy);
		}
#pragma warning restore 0169

		static Delegate cb_setCreatedBy_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCreatedBy_Ljava_lang_String_Handler ()
		{
			if (cb_setCreatedBy_Ljava_lang_String_ == null)
				cb_setCreatedBy_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreatedBy_Ljava_lang_String_);
			return cb_setCreatedBy_Ljava_lang_String_;
		}

		static void n_SetCreatedBy_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreatedBy = p0;
		}
#pragma warning restore 0169

		IntPtr id_getCreatedBy;
		IntPtr id_setCreatedBy_Ljava_lang_String_;
		public unsafe string CreatedBy {
			get {
				if (id_getCreatedBy == IntPtr.Zero)
					id_getCreatedBy = JNIEnv.GetMethodID (class_ref, "getCreatedBy", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCreatedBy), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setCreatedBy_Ljava_lang_String_ == IntPtr.Zero)
					id_setCreatedBy_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCreatedBy", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setCreatedBy_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getCreatedDate;
#pragma warning disable 0169
		static Delegate GetGetCreatedDateHandler ()
		{
			if (cb_getCreatedDate == null)
				cb_getCreatedDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedDate);
			return cb_getCreatedDate;
		}

		static IntPtr n_GetCreatedDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreatedDate);
		}
#pragma warning restore 0169

		static Delegate cb_setCreatedDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCreatedDate_Ljava_lang_String_Handler ()
		{
			if (cb_setCreatedDate_Ljava_lang_String_ == null)
				cb_setCreatedDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreatedDate_Ljava_lang_String_);
			return cb_setCreatedDate_Ljava_lang_String_;
		}

		static void n_SetCreatedDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreatedDate = p0;
		}
#pragma warning restore 0169

		IntPtr id_getCreatedDate;
		IntPtr id_setCreatedDate_Ljava_lang_String_;
		public unsafe string CreatedDate {
			get {
				if (id_getCreatedDate == IntPtr.Zero)
					id_getCreatedDate = JNIEnv.GetMethodID (class_ref, "getCreatedDate", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCreatedDate), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setCreatedDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setCreatedDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCreatedDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setCreatedDate_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getETagRequest;
#pragma warning disable 0169
		static Delegate GetGetETagRequestHandler ()
		{
			if (cb_getETagRequest == null)
				cb_getETagRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetETagRequest);
			return cb_getETagRequest;
		}

		static IntPtr n_GetETagRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETagRequest);
		}
#pragma warning restore 0169

		static Delegate cb_setETagRequest_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetETagRequest_Ljava_lang_String_Handler ()
		{
			if (cb_setETagRequest_Ljava_lang_String_ == null)
				cb_setETagRequest_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetETagRequest_Ljava_lang_String_);
			return cb_setETagRequest_Ljava_lang_String_;
		}

		static void n_SetETagRequest_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ETagRequest = p0;
		}
#pragma warning restore 0169

		IntPtr id_getETagRequest;
		IntPtr id_setETagRequest_Ljava_lang_String_;
		public unsafe string ETagRequest {
			get {
				if (id_getETagRequest == IntPtr.Zero)
					id_getETagRequest = JNIEnv.GetMethodID (class_ref, "getETagRequest", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getETagRequest), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setETagRequest_Ljava_lang_String_ == IntPtr.Zero)
					id_setETagRequest_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setETagRequest", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setETagRequest_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getETagResponse;
#pragma warning disable 0169
		static Delegate GetGetETagResponseHandler ()
		{
			if (cb_getETagResponse == null)
				cb_getETagResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetETagResponse);
			return cb_getETagResponse;
		}

		static IntPtr n_GetETagResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETagResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setETagResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetETagResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setETagResponse_Ljava_lang_String_ == null)
				cb_setETagResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetETagResponse_Ljava_lang_String_);
			return cb_setETagResponse_Ljava_lang_String_;
		}

		static void n_SetETagResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ETagResponse = p0;
		}
#pragma warning restore 0169

		IntPtr id_getETagResponse;
		IntPtr id_setETagResponse_Ljava_lang_String_;
		public unsafe string ETagResponse {
			get {
				if (id_getETagResponse == IntPtr.Zero)
					id_getETagResponse = JNIEnv.GetMethodID (class_ref, "getETagResponse", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getETagResponse), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setETagResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setETagResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setETagResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setETagResponse_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getModifiedDate;
#pragma warning disable 0169
		static Delegate GetGetModifiedDateHandler ()
		{
			if (cb_getModifiedDate == null)
				cb_getModifiedDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModifiedDate);
			return cb_getModifiedDate;
		}

		static IntPtr n_GetModifiedDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ModifiedDate);
		}
#pragma warning restore 0169

		static Delegate cb_setModifiedDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetModifiedDate_Ljava_lang_String_Handler ()
		{
			if (cb_setModifiedDate_Ljava_lang_String_ == null)
				cb_setModifiedDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetModifiedDate_Ljava_lang_String_);
			return cb_setModifiedDate_Ljava_lang_String_;
		}

		static void n_SetModifiedDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ModifiedDate = p0;
		}
#pragma warning restore 0169

		IntPtr id_getModifiedDate;
		IntPtr id_setModifiedDate_Ljava_lang_String_;
		public unsafe string ModifiedDate {
			get {
				if (id_getModifiedDate == IntPtr.Zero)
					id_getModifiedDate = JNIEnv.GetMethodID (class_ref, "getModifiedDate", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getModifiedDate), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setModifiedDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setModifiedDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setModifiedDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setModifiedDate_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getTempLink;
#pragma warning disable 0169
		static Delegate GetGetTempLinkHandler ()
		{
			if (cb_getTempLink == null)
				cb_getTempLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTempLink);
			return cb_getTempLink;
		}

		static IntPtr n_GetTempLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TempLink);
		}
#pragma warning restore 0169

		static Delegate cb_setTempLink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTempLink_Ljava_lang_String_Handler ()
		{
			if (cb_setTempLink_Ljava_lang_String_ == null)
				cb_setTempLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTempLink_Ljava_lang_String_);
			return cb_setTempLink_Ljava_lang_String_;
		}

		static void n_SetTempLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TempLink = p0;
		}
#pragma warning restore 0169

		IntPtr id_getTempLink;
		IntPtr id_setTempLink_Ljava_lang_String_;
		public unsafe string TempLink {
			get {
				if (id_getTempLink == IntPtr.Zero)
					id_getTempLink = JNIEnv.GetMethodID (class_ref, "getTempLink", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getTempLink), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setTempLink_Ljava_lang_String_ == IntPtr.Zero)
					id_setTempLink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTempLink", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setTempLink_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetVersion);
			return cb_getVersion;
		}

		static long n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_J;
#pragma warning disable 0169
		static Delegate GetSetVersion_JHandler ()
		{
			if (cb_setVersion_J == null)
				cb_setVersion_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetVersion_J);
			return cb_setVersion_J;
		}

		static void n_SetVersion_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Version = p0;
		}
#pragma warning restore 0169

		IntPtr id_getVersion;
		IntPtr id_setVersion_J;
		public unsafe long Version {
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()J");
				return JNIEnv.CallLongMethod (Handle, id_getVersion);
			}
			set {
				if (id_setVersion_J == IntPtr.Zero)
					id_setVersion_J = JNIEnv.GetMethodID (class_ref, "setVersion", "(J)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setVersion_J, __args);
			}
		}

		static Delegate cb_isExclusivelyTrashed;
#pragma warning disable 0169
		static Delegate GetIsExclusivelyTrashedHandler ()
		{
			if (cb_isExclusivelyTrashed == null)
				cb_isExclusivelyTrashed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsExclusivelyTrashed);
			return cb_isExclusivelyTrashed;
		}

		static IntPtr n_IsExclusivelyTrashed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsExclusivelyTrashed ());
		}
#pragma warning restore 0169

		IntPtr id_isExclusivelyTrashed;
		public unsafe global::Java.Lang.Boolean IsExclusivelyTrashed ()
		{
			if (id_isExclusivelyTrashed == IntPtr.Zero)
				id_isExclusivelyTrashed = JNIEnv.GetMethodID (class_ref, "isExclusivelyTrashed", "()Ljava/lang/Boolean;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (Handle, id_isExclusivelyTrashed), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isRecursivelyTrashed;
#pragma warning disable 0169
		static Delegate GetIsRecursivelyTrashedHandler ()
		{
			if (cb_isRecursivelyTrashed == null)
				cb_isRecursivelyTrashed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsRecursivelyTrashed);
			return cb_isRecursivelyTrashed;
		}

		static IntPtr n_IsRecursivelyTrashed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsRecursivelyTrashed ());
		}
#pragma warning restore 0169

		IntPtr id_isRecursivelyTrashed;
		public unsafe global::Java.Lang.Boolean IsRecursivelyTrashed ()
		{
			if (id_isRecursivelyTrashed == IntPtr.Zero)
				id_isRecursivelyTrashed = JNIEnv.GetMethodID (class_ref, "isRecursivelyTrashed", "()Ljava/lang/Boolean;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (Handle, id_isRecursivelyTrashed), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isRoot;
#pragma warning disable 0169
		static Delegate GetIsRootHandler ()
		{
			if (cb_isRoot == null)
				cb_isRoot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsRoot);
			return cb_isRoot;
		}

		static IntPtr n_IsRoot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsRoot ());
		}
#pragma warning restore 0169

		IntPtr id_isRoot;
		public unsafe global::Java.Lang.Boolean IsRoot ()
		{
			if (id_isRoot == IntPtr.Zero)
				id_isRoot = JNIEnv.GetMethodID (class_ref, "isRoot", "()Ljava/lang/Boolean;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (Handle, id_isRoot), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isShared;
#pragma warning disable 0169
		static Delegate GetIsSharedHandler ()
		{
			if (cb_isShared == null)
				cb_isShared = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsShared);
			return cb_isShared;
		}

		static IntPtr n_IsShared (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsShared ());
		}
#pragma warning restore 0169

		IntPtr id_isShared;
		public unsafe global::Java.Lang.Boolean IsShared ()
		{
			if (id_isShared == IntPtr.Zero)
				id_isShared = JNIEnv.GetMethodID (class_ref, "isShared", "()Ljava/lang/Boolean;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (Handle, id_isShared), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setExclusivelyTrashed_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetExclusivelyTrashed_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setExclusivelyTrashed_Ljava_lang_Boolean_ == null)
				cb_setExclusivelyTrashed_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExclusivelyTrashed_Ljava_lang_Boolean_);
			return cb_setExclusivelyTrashed_Ljava_lang_Boolean_;
		}

		static void n_SetExclusivelyTrashed_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetExclusivelyTrashed (p0);
		}
#pragma warning restore 0169

		IntPtr id_setExclusivelyTrashed_Ljava_lang_Boolean_;
		public unsafe void SetExclusivelyTrashed (global::Java.Lang.Boolean p0)
		{
			if (id_setExclusivelyTrashed_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setExclusivelyTrashed_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setExclusivelyTrashed", "(Ljava/lang/Boolean;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setExclusivelyTrashed_Ljava_lang_Boolean_, __args);
		}

		static Delegate cb_setIsRoot_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetIsRoot_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setIsRoot_Ljava_lang_Boolean_ == null)
				cb_setIsRoot_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsRoot_Ljava_lang_Boolean_);
			return cb_setIsRoot_Ljava_lang_Boolean_;
		}

		static void n_SetIsRoot_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIsRoot (p0);
		}
#pragma warning restore 0169

		IntPtr id_setIsRoot_Ljava_lang_Boolean_;
		public unsafe void SetIsRoot (global::Java.Lang.Boolean p0)
		{
			if (id_setIsRoot_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setIsRoot_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setIsRoot", "(Ljava/lang/Boolean;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setIsRoot_Ljava_lang_Boolean_, __args);
		}

		static Delegate cb_setIsShared_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetIsShared_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setIsShared_Ljava_lang_Boolean_ == null)
				cb_setIsShared_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsShared_Ljava_lang_Boolean_);
			return cb_setIsShared_Ljava_lang_Boolean_;
		}

		static void n_SetIsShared_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIsShared (p0);
		}
#pragma warning restore 0169

		IntPtr id_setIsShared_Ljava_lang_Boolean_;
		public unsafe void SetIsShared (global::Java.Lang.Boolean p0)
		{
			if (id_setIsShared_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setIsShared_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setIsShared", "(Ljava/lang/Boolean;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setIsShared_Ljava_lang_Boolean_, __args);
		}

		static Delegate cb_setRecursivelyTrashed_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetRecursivelyTrashed_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setRecursivelyTrashed_Ljava_lang_Boolean_ == null)
				cb_setRecursivelyTrashed_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecursivelyTrashed_Ljava_lang_Boolean_);
			return cb_setRecursivelyTrashed_Ljava_lang_Boolean_;
		}

		static void n_SetRecursivelyTrashed_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRecursivelyTrashed (p0);
		}
#pragma warning restore 0169

		IntPtr id_setRecursivelyTrashed_Ljava_lang_Boolean_;
		public unsafe void SetRecursivelyTrashed (global::Java.Lang.Boolean p0)
		{
			if (id_setRecursivelyTrashed_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setRecursivelyTrashed_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setRecursivelyTrashed", "(Ljava/lang/Boolean;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setRecursivelyTrashed_Ljava_lang_Boolean_, __args);
		}

		static Delegate cb_getContentProperties;
#pragma warning disable 0169
		static Delegate GetGetContentPropertiesHandler ()
		{
			if (cb_getContentProperties == null)
				cb_getContentProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentProperties);
			return cb_getContentProperties;
		}

		static IntPtr n_GetContentProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentProperties);
		}
#pragma warning restore 0169

		static Delegate cb_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
#pragma warning disable 0169
		static Delegate GetSetContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_Handler ()
		{
			if (cb_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ == null)
				cb_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_);
			return cb_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
		}

		static void n_SetContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ContentProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentProperties = p0;
		}
#pragma warning restore 0169

		IntPtr id_getContentProperties;
		IntPtr id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_;
		public unsafe global::Com.Amazon.Clouddrive.Model.ContentProperties ContentProperties {
			get {
				if (id_getContentProperties == IntPtr.Zero)
					id_getContentProperties = JNIEnv.GetMethodID (class_ref, "getContentProperties", "()Lcom/amazon/clouddrive/model/ContentProperties;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ContentProperties> (JNIEnv.CallObjectMethod (Handle, id_getContentProperties), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ == IntPtr.Zero)
					id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_ = JNIEnv.GetMethodID (class_ref, "setContentProperties", "(Lcom/amazon/clouddrive/model/ContentProperties;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setContentProperties_Lcom_amazon_clouddrive_model_ContentProperties_, __args);
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Description = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDescription;
		IntPtr id_setDescription_Ljava_lang_String_;
		public unsafe string Description {
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setDescription_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		IntPtr id_getId;
		IntPtr id_setId_Ljava_lang_String_;
		public unsafe string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setId_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getKind;
#pragma warning disable 0169
		static Delegate GetGetKindHandler ()
		{
			if (cb_getKind == null)
				cb_getKind = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKind);
			return cb_getKind;
		}

		static IntPtr n_GetKind (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Kind);
		}
#pragma warning restore 0169

		static Delegate cb_setKind_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKind_Ljava_lang_String_Handler ()
		{
			if (cb_setKind_Ljava_lang_String_ == null)
				cb_setKind_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKind_Ljava_lang_String_);
			return cb_setKind_Ljava_lang_String_;
		}

		static void n_SetKind_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Kind = p0;
		}
#pragma warning restore 0169

		IntPtr id_getKind;
		IntPtr id_setKind_Ljava_lang_String_;
		public unsafe string Kind {
			get {
				if (id_getKind == IntPtr.Zero)
					id_getKind = JNIEnv.GetMethodID (class_ref, "getKind", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getKind), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setKind_Ljava_lang_String_ == IntPtr.Zero)
					id_setKind_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKind", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setKind_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getLabels;
#pragma warning disable 0169
		static Delegate GetGetLabelsHandler ()
		{
			if (cb_getLabels == null)
				cb_getLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabels);
			return cb_getLabels;
		}

		static IntPtr n_GetLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Labels);
		}
#pragma warning restore 0169

		static Delegate cb_setLabels_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetLabels_Ljava_util_List_Handler ()
		{
			if (cb_setLabels_Ljava_util_List_ == null)
				cb_setLabels_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabels_Ljava_util_List_);
			return cb_setLabels_Ljava_util_List_;
		}

		static void n_SetLabels_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Labels = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLabels;
		IntPtr id_setLabels_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<string> Labels {
			get {
				if (id_getLabels == IntPtr.Zero)
					id_getLabels = JNIEnv.GetMethodID (class_ref, "getLabels", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getLabels), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setLabels_Ljava_util_List_ == IntPtr.Zero)
					id_setLabels_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setLabels", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setLabels_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		IntPtr id_getName;
		IntPtr id_setName_Ljava_lang_String_;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setName_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getParents;
#pragma warning disable 0169
		static Delegate GetGetParentsHandler ()
		{
			if (cb_getParents == null)
				cb_getParents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParents);
			return cb_getParents;
		}

		static IntPtr n_GetParents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Parents);
		}
#pragma warning restore 0169

		static Delegate cb_setParents_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetParents_Ljava_util_List_Handler ()
		{
			if (cb_setParents_Ljava_util_List_ == null)
				cb_setParents_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParents_Ljava_util_List_);
			return cb_setParents_Ljava_util_List_;
		}

		static void n_SetParents_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Parents = p0;
		}
#pragma warning restore 0169

		IntPtr id_getParents;
		IntPtr id_setParents_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<string> Parents {
			get {
				if (id_getParents == IntPtr.Zero)
					id_getParents = JNIEnv.GetMethodID (class_ref, "getParents", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getParents), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setParents_Ljava_util_List_ == IntPtr.Zero)
					id_setParents_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setParents", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setParents_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getProperties;
#pragma warning disable 0169
		static Delegate GetGetPropertiesHandler ()
		{
			if (cb_getProperties == null)
				cb_getProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProperties);
			return cb_getProperties;
		}

		static IntPtr n_GetProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (__this.Properties);
		}
#pragma warning restore 0169

		static Delegate cb_setProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetProperties_Ljava_util_Map_Handler ()
		{
			if (cb_setProperties_Ljava_util_Map_ == null)
				cb_setProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProperties_Ljava_util_Map_);
			return cb_setProperties_Ljava_util_Map_;
		}

		static void n_SetProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Properties = p0;
		}
#pragma warning restore 0169

		IntPtr id_getProperties;
		IntPtr id_setProperties_Ljava_util_Map_;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, string>> Properties {
			get {
				if (id_getProperties == IntPtr.Zero)
					id_getProperties = JNIEnv.GetMethodID (class_ref, "getProperties", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getProperties), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setProperties_Ljava_util_Map_ == IntPtr.Zero)
					id_setProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setProperties", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IDictionary<string, string>>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setProperties_Ljava_util_Map_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setStatus_Ljava_lang_String_ == null)
				cb_setStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Ljava_lang_String_);
			return cb_setStatus_Ljava_lang_String_;
		}

		static void n_SetStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.INode __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.INode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		IntPtr id_getStatus;
		IntPtr id_setStatus_Ljava_lang_String_;
		public unsafe string Status {
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setStatus_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setStatus_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}

}
