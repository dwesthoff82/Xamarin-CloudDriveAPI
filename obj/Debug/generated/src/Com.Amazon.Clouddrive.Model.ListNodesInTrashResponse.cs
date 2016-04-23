using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashResponse']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/ListNodesInTrashResponse", DoNotGenerateAcw=true)]
	public partial class ListNodesInTrashResponse : global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse, global::Com.Amazon.Clouddrive.Model.INodeListingResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/ListNodesInTrashResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ListNodesInTrashResponse); }
		}

		protected ListNodesInTrashResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashResponse']/constructor[@name='ListNodesInTrashResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ListNodesInTrashResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ListNodesInTrashResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate Get_getDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n__getData);
			return cb_getData;
		}

		static IntPtr n__getData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodesInTrashResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.ToLocalJniHandle (__this._getData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashResponse']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()Ljava/util/List;", "Get_getDataHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Amazon.Clouddrive.Model.Node> _getData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/List;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setData_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_util_List_Handler ()
		{
			if (cb_setData_Ljava_util_List_ == null)
				cb_setData_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_util_List_);
			return cb_setData_Ljava_util_List_;
		}

		static void n_SetData_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListNodesInTrashResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListNodesInTrashResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setData_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListNodesInTrashResponse']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.amazon.clouddrive.model.Node&gt;']]"
		[Register ("setData", "(Ljava/util/List;)V", "GetSetData_Ljava_util_List_Handler")]
		public virtual unsafe void SetData (global::System.Collections.Generic.IList<global::Com.Amazon.Clouddrive.Model.Node> p0)
		{
			if (id_setData_Ljava_util_List_ == IntPtr.Zero)
				id_setData_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Amazon.Clouddrive.Model.Node>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setData_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
