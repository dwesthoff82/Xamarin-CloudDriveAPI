using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodePropertyRequest']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/GetNodePropertyRequest", DoNotGenerateAcw=true)]
	public partial class GetNodePropertyRequest : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/GetNodePropertyRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetNodePropertyRequest); }
		}

		protected GetNodePropertyRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodePropertyRequest']/constructor[@name='GetNodePropertyRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GetNodePropertyRequest (string p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (GetNodePropertyRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodePropertyRequest']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodePropertyRequest']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		static Delegate cb_setKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKey_Ljava_lang_String_Handler ()
		{
			if (cb_setKey_Ljava_lang_String_ == null)
				cb_setKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKey_Ljava_lang_String_);
			return cb_setKey_Ljava_lang_String_;
		}

		static void n_SetKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Key = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		static IntPtr id_setKey_Ljava_lang_String_;
		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodePropertyRequest']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodePropertyRequest']/method[@name='setKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKey", "(Ljava/lang/String;)V", "GetSetKey_Ljava_lang_String_Handler")]
			set {
				if (id_setKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOwner;
#pragma warning disable 0169
		static Delegate GetGetOwnerHandler ()
		{
			if (cb_getOwner == null)
				cb_getOwner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwner);
			return cb_getOwner;
		}

		static IntPtr n_GetOwner (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Owner);
		}
#pragma warning restore 0169

		static Delegate cb_setOwner_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOwner_Ljava_lang_String_Handler ()
		{
			if (cb_setOwner_Ljava_lang_String_ == null)
				cb_setOwner_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOwner_Ljava_lang_String_);
			return cb_setOwner_Ljava_lang_String_;
		}

		static void n_SetOwner_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Owner = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOwner;
		static IntPtr id_setOwner_Ljava_lang_String_;
		public virtual unsafe string Owner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodePropertyRequest']/method[@name='getOwner' and count(parameter)=0]"
			[Register ("getOwner", "()Ljava/lang/String;", "GetGetOwnerHandler")]
			get {
				if (id_getOwner == IntPtr.Zero)
					id_getOwner = JNIEnv.GetMethodID (class_ref, "getOwner", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOwner), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOwner", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodePropertyRequest']/method[@name='setOwner' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOwner", "(Ljava/lang/String;)V", "GetSetOwner_Ljava_lang_String_Handler")]
			set {
				if (id_setOwner_Ljava_lang_String_ == IntPtr.Zero)
					id_setOwner_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOwner", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOwner_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOwner", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetNodePropertyRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetNodePropertyRequest']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveRequest']]"
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

	}
}
