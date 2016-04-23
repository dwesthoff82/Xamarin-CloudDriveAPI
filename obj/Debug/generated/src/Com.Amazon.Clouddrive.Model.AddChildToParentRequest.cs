using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AddChildToParentRequest']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/AddChildToParentRequest", DoNotGenerateAcw=true)]
	public partial class AddChildToParentRequest : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/AddChildToParentRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AddChildToParentRequest); }
		}

		protected AddChildToParentRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AddChildToParentRequest']/constructor[@name='AddChildToParentRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AddChildToParentRequest (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (AddChildToParentRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getChildId;
#pragma warning disable 0169
		static Delegate GetGetChildIdHandler ()
		{
			if (cb_getChildId == null)
				cb_getChildId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChildId);
			return cb_getChildId;
		}

		static IntPtr n_GetChildId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChildId);
		}
#pragma warning restore 0169

		static Delegate cb_setChildId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChildId_Ljava_lang_String_Handler ()
		{
			if (cb_setChildId_Ljava_lang_String_ == null)
				cb_setChildId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChildId_Ljava_lang_String_);
			return cb_setChildId_Ljava_lang_String_;
		}

		static void n_SetChildId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChildId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChildId;
		static IntPtr id_setChildId_Ljava_lang_String_;
		public virtual unsafe string ChildId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AddChildToParentRequest']/method[@name='getChildId' and count(parameter)=0]"
			[Register ("getChildId", "()Ljava/lang/String;", "GetGetChildIdHandler")]
			get {
				if (id_getChildId == IntPtr.Zero)
					id_getChildId = JNIEnv.GetMethodID (class_ref, "getChildId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getChildId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChildId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AddChildToParentRequest']/method[@name='setChildId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChildId", "(Ljava/lang/String;)V", "GetSetChildId_Ljava_lang_String_Handler")]
			set {
				if (id_setChildId_Ljava_lang_String_ == IntPtr.Zero)
					id_setChildId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChildId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setChildId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChildId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getParentId;
#pragma warning disable 0169
		static Delegate GetGetParentIdHandler ()
		{
			if (cb_getParentId == null)
				cb_getParentId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParentId);
			return cb_getParentId;
		}

		static IntPtr n_GetParentId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ParentId);
		}
#pragma warning restore 0169

		static Delegate cb_setParentId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetParentId_Ljava_lang_String_Handler ()
		{
			if (cb_setParentId_Ljava_lang_String_ == null)
				cb_setParentId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParentId_Ljava_lang_String_);
			return cb_setParentId_Ljava_lang_String_;
		}

		static void n_SetParentId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParentId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getParentId;
		static IntPtr id_setParentId_Ljava_lang_String_;
		public virtual unsafe string ParentId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AddChildToParentRequest']/method[@name='getParentId' and count(parameter)=0]"
			[Register ("getParentId", "()Ljava/lang/String;", "GetGetParentIdHandler")]
			get {
				if (id_getParentId == IntPtr.Zero)
					id_getParentId = JNIEnv.GetMethodID (class_ref, "getParentId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getParentId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParentId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AddChildToParentRequest']/method[@name='setParentId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setParentId", "(Ljava/lang/String;)V", "GetSetParentId_Ljava_lang_String_Handler")]
			set {
				if (id_setParentId_Ljava_lang_String_ == IntPtr.Zero)
					id_setParentId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setParentId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setParentId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParentId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AddChildToParentRequest']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveRequest']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveRequest;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withChildId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithChildId_Ljava_lang_String_Handler ()
		{
			if (cb_withChildId_Ljava_lang_String_ == null)
				cb_withChildId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithChildId_Ljava_lang_String_);
			return cb_withChildId_Ljava_lang_String_;
		}

		static IntPtr n_WithChildId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithChildId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withChildId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AddChildToParentRequest']/method[@name='withChildId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withChildId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/AddChildToParentRequest;", "GetWithChildId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest WithChildId (string p0)
		{
			if (id_withChildId_Ljava_lang_String_ == IntPtr.Zero)
				id_withChildId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withChildId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/AddChildToParentRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (JNIEnv.CallObjectMethod  (Handle, id_withChildId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withChildId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/AddChildToParentRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withParentId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithParentId_Ljava_lang_String_Handler ()
		{
			if (cb_withParentId_Ljava_lang_String_ == null)
				cb_withParentId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithParentId_Ljava_lang_String_);
			return cb_withParentId_Ljava_lang_String_;
		}

		static IntPtr n_WithParentId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithParentId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withParentId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='AddChildToParentRequest']/method[@name='withParentId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withParentId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/AddChildToParentRequest;", "GetWithParentId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest WithParentId (string p0)
		{
			if (id_withParentId_Ljava_lang_String_ == IntPtr.Zero)
				id_withParentId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withParentId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/AddChildToParentRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (JNIEnv.CallObjectMethod  (Handle, id_withParentId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.AddChildToParentRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withParentId", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/AddChildToParentRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
