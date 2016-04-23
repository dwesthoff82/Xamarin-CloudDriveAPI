using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveResponse']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/PaginatedCloudDriveResponse", DoNotGenerateAcw=true)]
	public abstract partial class PaginatedCloudDriveResponse : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/PaginatedCloudDriveResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaginatedCloudDriveResponse); }
		}

		protected PaginatedCloudDriveResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveResponse']/constructor[@name='PaginatedCloudDriveResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaginatedCloudDriveResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PaginatedCloudDriveResponse)) {
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

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCount);
			return cb_getCount;
		}

		static long n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static Delegate cb_setCount_J;
#pragma warning disable 0169
		static Delegate GetSetCount_JHandler ()
		{
			if (cb_setCount_J == null)
				cb_setCount_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetCount_J);
			return cb_setCount_J;
		}

		static void n_SetCount_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Count = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		static IntPtr id_setCount_J;
		public virtual unsafe long Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveResponse']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()J", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveResponse']/method[@name='setCount' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCount", "(J)V", "GetSetCount_JHandler")]
			set {
				if (id_setCount_J == IntPtr.Zero)
					id_setCount_J = JNIEnv.GetMethodID (class_ref, "setCount", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCount_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCount", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNextToken;
#pragma warning disable 0169
		static Delegate GetGetNextTokenHandler ()
		{
			if (cb_getNextToken == null)
				cb_getNextToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextToken);
			return cb_getNextToken;
		}

		static IntPtr n_GetNextToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextToken);
		}
#pragma warning restore 0169

		static Delegate cb_setNextToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNextToken_Ljava_lang_String_Handler ()
		{
			if (cb_setNextToken_Ljava_lang_String_ == null)
				cb_setNextToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNextToken_Ljava_lang_String_);
			return cb_setNextToken_Ljava_lang_String_;
		}

		static void n_SetNextToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NextToken = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNextToken;
		static IntPtr id_setNextToken_Ljava_lang_String_;
		public virtual unsafe string NextToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveResponse']/method[@name='getNextToken' and count(parameter)=0]"
			[Register ("getNextToken", "()Ljava/lang/String;", "GetGetNextTokenHandler")]
			get {
				if (id_getNextToken == IntPtr.Zero)
					id_getNextToken = JNIEnv.GetMethodID (class_ref, "getNextToken", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNextToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveResponse']/method[@name='setNextToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNextToken", "(Ljava/lang/String;)V", "GetSetNextToken_Ljava_lang_String_Handler")]
			set {
				if (id_setNextToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setNextToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNextToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNextToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNextToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveResponse']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveResponse']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveResponse;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveResponse;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/CloudDriveResponse;)I"), __args);
				return __ret;
			} finally {
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
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object another = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_another, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (another);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveResponse']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='Java.Lang.Object']]"
		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public abstract global::System.Int32 CompareTo (global::Java.Lang.Object another);

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/PaginatedCloudDriveResponse", DoNotGenerateAcw=true)]
	internal partial class PaginatedCloudDriveResponseInvoker : PaginatedCloudDriveResponse {

		public PaginatedCloudDriveResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaginatedCloudDriveResponseInvoker); }
		}

		static IntPtr id_compareTo_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveResponse']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='Java.Lang.Object']]"
		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public override unsafe global::System.Int32 CompareTo (global::Java.Lang.Object another)
		{
			if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (another);
				global::System.Int32 __ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

	}

}
