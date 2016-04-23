using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PostNodeRequest']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/PostNodeRequest", DoNotGenerateAcw=true)]
	public partial class PostNodeRequest : global::Com.Amazon.Clouddrive.Model.EditableNodeRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/PostNodeRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PostNodeRequest); }
		}

		protected PostNodeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PostNodeRequest']/constructor[@name='PostNodeRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PostNodeRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PostNodeRequest)) {
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

		static Delegate cb_getLocalId;
#pragma warning disable 0169
		static Delegate GetGetLocalIdHandler ()
		{
			if (cb_getLocalId == null)
				cb_getLocalId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalId);
			return cb_getLocalId;
		}

		static IntPtr n_GetLocalId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.PostNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PostNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalId);
		}
#pragma warning restore 0169

		static Delegate cb_setLocalId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocalId_Ljava_lang_String_Handler ()
		{
			if (cb_setLocalId_Ljava_lang_String_ == null)
				cb_setLocalId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocalId_Ljava_lang_String_);
			return cb_setLocalId_Ljava_lang_String_;
		}

		static void n_SetLocalId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.PostNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PostNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalId;
		static IntPtr id_setLocalId_Ljava_lang_String_;
		public virtual unsafe string LocalId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PostNodeRequest']/method[@name='getLocalId' and count(parameter)=0]"
			[Register ("getLocalId", "()Ljava/lang/String;", "GetGetLocalIdHandler")]
			get {
				if (id_getLocalId == IntPtr.Zero)
					id_getLocalId = JNIEnv.GetMethodID (class_ref, "getLocalId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLocalId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PostNodeRequest']/method[@name='setLocalId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocalId", "(Ljava/lang/String;)V", "GetSetLocalId_Ljava_lang_String_Handler")]
			set {
				if (id_setLocalId_Ljava_lang_String_ == IntPtr.Zero)
					id_setLocalId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLocalId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLocalId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocalId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.PostNodeRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PostNodeRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.EditableNodeRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.EditableNodeRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PostNodeRequest']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.EditableNodeRequest']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/EditableNodeRequest;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.EditableNodeRequest p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/EditableNodeRequest;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_EditableNodeRequest_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/EditableNodeRequest;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
