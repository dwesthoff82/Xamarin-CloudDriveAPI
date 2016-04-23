using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IGetChangesResponse']"
	[Register ("com/amazon/clouddrive/model/IGetChangesResponse", "", "Com.Amazon.Clouddrive.Model.IGetChangesResponseInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.amazon.clouddrive.model.INode"})]
	public partial interface IGetChangesResponse : global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse {

		string Checkpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IGetChangesResponse']/method[@name='getCheckpoint' and count(parameter)=0]"
			[Register ("getCheckpoint", "()Ljava/lang/String;", "GetGetCheckpointHandler:Com.Amazon.Clouddrive.Model.IGetChangesResponseInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IGetChangesResponse']/method[@name='setCheckpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCheckpoint", "(Ljava/lang/String;)V", "GetSetCheckpoint_Ljava_lang_String_Handler:Com.Amazon.Clouddrive.Model.IGetChangesResponseInvoker, CloudDriveAPI")] set;
		}

		global::System.Collections.IList Nodes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IGetChangesResponse']/method[@name='getNodes' and count(parameter)=0]"
			[Register ("getNodes", "()Ljava/util/List;", "GetGetNodesHandler:Com.Amazon.Clouddrive.Model.IGetChangesResponseInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IGetChangesResponse']/method[@name='setNodes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
			[Register ("setNodes", "(Ljava/util/List;)V", "GetSetNodes_Ljava_util_List_Handler:Com.Amazon.Clouddrive.Model.IGetChangesResponseInvoker, CloudDriveAPI")] set;
		}

		bool Reset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IGetChangesResponse']/method[@name='isReset' and count(parameter)=0]"
			[Register ("isReset", "()Z", "GetIsResetHandler:Com.Amazon.Clouddrive.Model.IGetChangesResponseInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/interface[@name='IGetChangesResponse']/method[@name='setReset' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setReset", "(Z)V", "GetSetReset_ZHandler:Com.Amazon.Clouddrive.Model.IGetChangesResponseInvoker, CloudDriveAPI")] set;
		}

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/IGetChangesResponse", DoNotGenerateAcw=true)]
	internal class IGetChangesResponseInvoker : global::Java.Lang.Object, IGetChangesResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/clouddrive/model/IGetChangesResponse");
		IntPtr class_ref;

		public static IGetChangesResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGetChangesResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.clouddrive.model.IGetChangesResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGetChangesResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IGetChangesResponseInvoker); }
		}

		static Delegate cb_getCheckpoint;
#pragma warning disable 0169
		static Delegate GetGetCheckpointHandler ()
		{
			if (cb_getCheckpoint == null)
				cb_getCheckpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCheckpoint);
			return cb_getCheckpoint;
		}

		static IntPtr n_GetCheckpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.IGetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IGetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Checkpoint);
		}
#pragma warning restore 0169

		static Delegate cb_setCheckpoint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCheckpoint_Ljava_lang_String_Handler ()
		{
			if (cb_setCheckpoint_Ljava_lang_String_ == null)
				cb_setCheckpoint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCheckpoint_Ljava_lang_String_);
			return cb_setCheckpoint_Ljava_lang_String_;
		}

		static void n_SetCheckpoint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.IGetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IGetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Checkpoint = p0;
		}
#pragma warning restore 0169

		IntPtr id_getCheckpoint;
		IntPtr id_setCheckpoint_Ljava_lang_String_;
		public unsafe string Checkpoint {
			get {
				if (id_getCheckpoint == IntPtr.Zero)
					id_getCheckpoint = JNIEnv.GetMethodID (class_ref, "getCheckpoint", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCheckpoint), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setCheckpoint_Ljava_lang_String_ == IntPtr.Zero)
					id_setCheckpoint_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCheckpoint", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setCheckpoint_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getNodes;
#pragma warning disable 0169
		static Delegate GetGetNodesHandler ()
		{
			if (cb_getNodes == null)
				cb_getNodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNodes);
			return cb_getNodes;
		}

		static IntPtr n_GetNodes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.IGetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IGetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Nodes);
		}
#pragma warning restore 0169

		static Delegate cb_setNodes_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetNodes_Ljava_util_List_Handler ()
		{
			if (cb_setNodes_Ljava_util_List_ == null)
				cb_setNodes_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNodes_Ljava_util_List_);
			return cb_setNodes_Ljava_util_List_;
		}

		static void n_SetNodes_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.IGetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IGetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Nodes = p0;
		}
#pragma warning restore 0169

		IntPtr id_getNodes;
		IntPtr id_setNodes_Ljava_util_List_;
		public unsafe global::System.Collections.IList Nodes {
			get {
				if (id_getNodes == IntPtr.Zero)
					id_getNodes = JNIEnv.GetMethodID (class_ref, "getNodes", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getNodes), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setNodes_Ljava_util_List_ == IntPtr.Zero)
					id_setNodes_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setNodes", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setNodes_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isReset;
#pragma warning disable 0169
		static Delegate GetIsResetHandler ()
		{
			if (cb_isReset == null)
				cb_isReset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReset);
			return cb_isReset;
		}

		static bool n_IsReset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.IGetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IGetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Reset;
		}
#pragma warning restore 0169

		static Delegate cb_setReset_Z;
#pragma warning disable 0169
		static Delegate GetSetReset_ZHandler ()
		{
			if (cb_setReset_Z == null)
				cb_setReset_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetReset_Z);
			return cb_setReset_Z;
		}

		static void n_SetReset_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Clouddrive.Model.IGetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IGetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset = p0;
		}
#pragma warning restore 0169

		IntPtr id_isReset;
		IntPtr id_setReset_Z;
		public unsafe bool Reset {
			get {
				if (id_isReset == IntPtr.Zero)
					id_isReset = JNIEnv.GetMethodID (class_ref, "isReset", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isReset);
			}
			set {
				if (id_setReset_Z == IntPtr.Zero)
					id_setReset_Z = JNIEnv.GetMethodID (class_ref, "setReset", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setReset_Z, __args);
			}
		}

		static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
		{
			if (cb_compareTo_Ljava_lang_Object_ == null)
				cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Ljava_lang_Object_);
			return cb_compareTo_Ljava_lang_Object_;
		}

		static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_another)
		{
			global::Com.Amazon.Clouddrive.Model.IGetChangesResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.IGetChangesResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object another = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_another, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (another);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_compareTo_Ljava_lang_Object_;
		public unsafe global::System.Int32 CompareTo (global::Java.Lang.Object another)
		{
			if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (another);
			global::System.Int32 __ret = JNIEnv.CallIntMethod (Handle, id_compareTo_Ljava_lang_Object_, __args);
			return __ret;
		}

	}

}
