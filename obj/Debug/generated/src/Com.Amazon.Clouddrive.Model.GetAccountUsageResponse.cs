using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/GetAccountUsageResponse", DoNotGenerateAcw=true)]
	public partial class GetAccountUsageResponse : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/GetAccountUsageResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetAccountUsageResponse); }
		}

		protected GetAccountUsageResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/constructor[@name='GetAccountUsageResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetAccountUsageResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GetAccountUsageResponse)) {
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

		static Delegate cb_getDoc;
#pragma warning disable 0169
		static Delegate GetGetDocHandler ()
		{
			if (cb_getDoc == null)
				cb_getDoc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDoc);
			return cb_getDoc;
		}

		static IntPtr n_GetDoc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Doc);
		}
#pragma warning restore 0169

		static Delegate cb_setDoc_Lcom_amazon_clouddrive_model_UsageSummary_;
#pragma warning disable 0169
		static Delegate GetSetDoc_Lcom_amazon_clouddrive_model_UsageSummary_Handler ()
		{
			if (cb_setDoc_Lcom_amazon_clouddrive_model_UsageSummary_ == null)
				cb_setDoc_Lcom_amazon_clouddrive_model_UsageSummary_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDoc_Lcom_amazon_clouddrive_model_UsageSummary_);
			return cb_setDoc_Lcom_amazon_clouddrive_model_UsageSummary_;
		}

		static void n_SetDoc_Lcom_amazon_clouddrive_model_UsageSummary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UsageSummary p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Doc = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDoc;
		static IntPtr id_setDoc_Lcom_amazon_clouddrive_model_UsageSummary_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UsageSummary Doc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/method[@name='getDoc' and count(parameter)=0]"
			[Register ("getDoc", "()Lcom/amazon/clouddrive/model/UsageSummary;", "GetGetDocHandler")]
			get {
				if (id_getDoc == IntPtr.Zero)
					id_getDoc = JNIEnv.GetMethodID (class_ref, "getDoc", "()Lcom/amazon/clouddrive/model/UsageSummary;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (JNIEnv.CallObjectMethod  (Handle, id_getDoc), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDoc", "()Lcom/amazon/clouddrive/model/UsageSummary;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/method[@name='setDoc' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.UsageSummary']]"
			[Register ("setDoc", "(Lcom/amazon/clouddrive/model/UsageSummary;)V", "GetSetDoc_Lcom_amazon_clouddrive_model_UsageSummary_Handler")]
			set {
				if (id_setDoc_Lcom_amazon_clouddrive_model_UsageSummary_ == IntPtr.Zero)
					id_setDoc_Lcom_amazon_clouddrive_model_UsageSummary_ = JNIEnv.GetMethodID (class_ref, "setDoc", "(Lcom/amazon/clouddrive/model/UsageSummary;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDoc_Lcom_amazon_clouddrive_model_UsageSummary_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDoc", "(Lcom/amazon/clouddrive/model/UsageSummary;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastCalculated;
#pragma warning disable 0169
		static Delegate GetGetLastCalculatedHandler ()
		{
			if (cb_getLastCalculated == null)
				cb_getLastCalculated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastCalculated);
			return cb_getLastCalculated;
		}

		static IntPtr n_GetLastCalculated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LastCalculated);
		}
#pragma warning restore 0169

		static Delegate cb_setLastCalculated_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLastCalculated_Ljava_lang_String_Handler ()
		{
			if (cb_setLastCalculated_Ljava_lang_String_ == null)
				cb_setLastCalculated_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastCalculated_Ljava_lang_String_);
			return cb_setLastCalculated_Ljava_lang_String_;
		}

		static void n_SetLastCalculated_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LastCalculated = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastCalculated;
		static IntPtr id_setLastCalculated_Ljava_lang_String_;
		public virtual unsafe string LastCalculated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/method[@name='getLastCalculated' and count(parameter)=0]"
			[Register ("getLastCalculated", "()Ljava/lang/String;", "GetGetLastCalculatedHandler")]
			get {
				if (id_getLastCalculated == IntPtr.Zero)
					id_getLastCalculated = JNIEnv.GetMethodID (class_ref, "getLastCalculated", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLastCalculated), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastCalculated", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/method[@name='setLastCalculated' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLastCalculated", "(Ljava/lang/String;)V", "GetSetLastCalculated_Ljava_lang_String_Handler")]
			set {
				if (id_setLastCalculated_Ljava_lang_String_ == IntPtr.Zero)
					id_setLastCalculated_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLastCalculated", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLastCalculated_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastCalculated", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOther;
#pragma warning disable 0169
		static Delegate GetGetOtherHandler ()
		{
			if (cb_getOther == null)
				cb_getOther = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOther);
			return cb_getOther;
		}

		static IntPtr n_GetOther (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Other);
		}
#pragma warning restore 0169

		static Delegate cb_setOther_Lcom_amazon_clouddrive_model_UsageSummary_;
#pragma warning disable 0169
		static Delegate GetSetOther_Lcom_amazon_clouddrive_model_UsageSummary_Handler ()
		{
			if (cb_setOther_Lcom_amazon_clouddrive_model_UsageSummary_ == null)
				cb_setOther_Lcom_amazon_clouddrive_model_UsageSummary_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOther_Lcom_amazon_clouddrive_model_UsageSummary_);
			return cb_setOther_Lcom_amazon_clouddrive_model_UsageSummary_;
		}

		static void n_SetOther_Lcom_amazon_clouddrive_model_UsageSummary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UsageSummary p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Other = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOther;
		static IntPtr id_setOther_Lcom_amazon_clouddrive_model_UsageSummary_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UsageSummary Other {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/method[@name='getOther' and count(parameter)=0]"
			[Register ("getOther", "()Lcom/amazon/clouddrive/model/UsageSummary;", "GetGetOtherHandler")]
			get {
				if (id_getOther == IntPtr.Zero)
					id_getOther = JNIEnv.GetMethodID (class_ref, "getOther", "()Lcom/amazon/clouddrive/model/UsageSummary;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (JNIEnv.CallObjectMethod  (Handle, id_getOther), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOther", "()Lcom/amazon/clouddrive/model/UsageSummary;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/method[@name='setOther' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.UsageSummary']]"
			[Register ("setOther", "(Lcom/amazon/clouddrive/model/UsageSummary;)V", "GetSetOther_Lcom_amazon_clouddrive_model_UsageSummary_Handler")]
			set {
				if (id_setOther_Lcom_amazon_clouddrive_model_UsageSummary_ == IntPtr.Zero)
					id_setOther_Lcom_amazon_clouddrive_model_UsageSummary_ = JNIEnv.GetMethodID (class_ref, "setOther", "(Lcom/amazon/clouddrive/model/UsageSummary;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOther_Lcom_amazon_clouddrive_model_UsageSummary_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOther", "(Lcom/amazon/clouddrive/model/UsageSummary;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPhoto;
#pragma warning disable 0169
		static Delegate GetGetPhotoHandler ()
		{
			if (cb_getPhoto == null)
				cb_getPhoto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoto);
			return cb_getPhoto;
		}

		static IntPtr n_GetPhoto (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Photo);
		}
#pragma warning restore 0169

		static Delegate cb_setPhoto_Lcom_amazon_clouddrive_model_UsageSummary_;
#pragma warning disable 0169
		static Delegate GetSetPhoto_Lcom_amazon_clouddrive_model_UsageSummary_Handler ()
		{
			if (cb_setPhoto_Lcom_amazon_clouddrive_model_UsageSummary_ == null)
				cb_setPhoto_Lcom_amazon_clouddrive_model_UsageSummary_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPhoto_Lcom_amazon_clouddrive_model_UsageSummary_);
			return cb_setPhoto_Lcom_amazon_clouddrive_model_UsageSummary_;
		}

		static void n_SetPhoto_Lcom_amazon_clouddrive_model_UsageSummary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UsageSummary p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Photo = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPhoto;
		static IntPtr id_setPhoto_Lcom_amazon_clouddrive_model_UsageSummary_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UsageSummary Photo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/method[@name='getPhoto' and count(parameter)=0]"
			[Register ("getPhoto", "()Lcom/amazon/clouddrive/model/UsageSummary;", "GetGetPhotoHandler")]
			get {
				if (id_getPhoto == IntPtr.Zero)
					id_getPhoto = JNIEnv.GetMethodID (class_ref, "getPhoto", "()Lcom/amazon/clouddrive/model/UsageSummary;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (JNIEnv.CallObjectMethod  (Handle, id_getPhoto), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhoto", "()Lcom/amazon/clouddrive/model/UsageSummary;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/method[@name='setPhoto' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.UsageSummary']]"
			[Register ("setPhoto", "(Lcom/amazon/clouddrive/model/UsageSummary;)V", "GetSetPhoto_Lcom_amazon_clouddrive_model_UsageSummary_Handler")]
			set {
				if (id_setPhoto_Lcom_amazon_clouddrive_model_UsageSummary_ == IntPtr.Zero)
					id_setPhoto_Lcom_amazon_clouddrive_model_UsageSummary_ = JNIEnv.GetMethodID (class_ref, "setPhoto", "(Lcom/amazon/clouddrive/model/UsageSummary;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPhoto_Lcom_amazon_clouddrive_model_UsageSummary_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPhoto", "(Lcom/amazon/clouddrive/model/UsageSummary;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideo;
#pragma warning disable 0169
		static Delegate GetGetVideoHandler ()
		{
			if (cb_getVideo == null)
				cb_getVideo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideo);
			return cb_getVideo;
		}

		static IntPtr n_GetVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Video);
		}
#pragma warning restore 0169

		static Delegate cb_setVideo_Lcom_amazon_clouddrive_model_UsageSummary_;
#pragma warning disable 0169
		static Delegate GetSetVideo_Lcom_amazon_clouddrive_model_UsageSummary_Handler ()
		{
			if (cb_setVideo_Lcom_amazon_clouddrive_model_UsageSummary_ == null)
				cb_setVideo_Lcom_amazon_clouddrive_model_UsageSummary_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideo_Lcom_amazon_clouddrive_model_UsageSummary_);
			return cb_setVideo_Lcom_amazon_clouddrive_model_UsageSummary_;
		}

		static void n_SetVideo_Lcom_amazon_clouddrive_model_UsageSummary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UsageSummary p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Video = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVideo;
		static IntPtr id_setVideo_Lcom_amazon_clouddrive_model_UsageSummary_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UsageSummary Video {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/method[@name='getVideo' and count(parameter)=0]"
			[Register ("getVideo", "()Lcom/amazon/clouddrive/model/UsageSummary;", "GetGetVideoHandler")]
			get {
				if (id_getVideo == IntPtr.Zero)
					id_getVideo = JNIEnv.GetMethodID (class_ref, "getVideo", "()Lcom/amazon/clouddrive/model/UsageSummary;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (JNIEnv.CallObjectMethod  (Handle, id_getVideo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideo", "()Lcom/amazon/clouddrive/model/UsageSummary;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/method[@name='setVideo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.UsageSummary']]"
			[Register ("setVideo", "(Lcom/amazon/clouddrive/model/UsageSummary;)V", "GetSetVideo_Lcom_amazon_clouddrive_model_UsageSummary_Handler")]
			set {
				if (id_setVideo_Lcom_amazon_clouddrive_model_UsageSummary_ == IntPtr.Zero)
					id_setVideo_Lcom_amazon_clouddrive_model_UsageSummary_ = JNIEnv.GetMethodID (class_ref, "setVideo", "(Lcom/amazon/clouddrive/model/UsageSummary;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVideo_Lcom_amazon_clouddrive_model_UsageSummary_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideo", "(Lcom/amazon/clouddrive/model/UsageSummary;)V"), __args);
				} finally {
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
			global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountUsageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountUsageResponse']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveResponse']]"
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

	}
}
