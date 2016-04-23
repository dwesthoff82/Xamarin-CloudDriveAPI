using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/ImageProperties", DoNotGenerateAcw=true)]
	public partial class ImageProperties : global::Java.Lang.Object, global::Java.Lang.IComparable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/ImageProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageProperties); }
		}

		protected ImageProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/constructor[@name='ImageProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImageProperties)) {
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

		static Delegate cb_getApertureValue;
#pragma warning disable 0169
		static Delegate GetGetApertureValueHandler ()
		{
			if (cb_getApertureValue == null)
				cb_getApertureValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApertureValue);
			return cb_getApertureValue;
		}

		static IntPtr n_GetApertureValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApertureValue);
		}
#pragma warning restore 0169

		static Delegate cb_setApertureValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApertureValue_Ljava_lang_String_Handler ()
		{
			if (cb_setApertureValue_Ljava_lang_String_ == null)
				cb_setApertureValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApertureValue_Ljava_lang_String_);
			return cb_setApertureValue_Ljava_lang_String_;
		}

		static void n_SetApertureValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApertureValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApertureValue;
		static IntPtr id_setApertureValue_Ljava_lang_String_;
		public virtual unsafe string ApertureValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getApertureValue' and count(parameter)=0]"
			[Register ("getApertureValue", "()Ljava/lang/String;", "GetGetApertureValueHandler")]
			get {
				if (id_getApertureValue == IntPtr.Zero)
					id_getApertureValue = JNIEnv.GetMethodID (class_ref, "getApertureValue", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApertureValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApertureValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setApertureValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApertureValue", "(Ljava/lang/String;)V", "GetSetApertureValue_Ljava_lang_String_Handler")]
			set {
				if (id_setApertureValue_Ljava_lang_String_ == IntPtr.Zero)
					id_setApertureValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApertureValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setApertureValue_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApertureValue", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCaptureMode;
#pragma warning disable 0169
		static Delegate GetGetCaptureModeHandler ()
		{
			if (cb_getCaptureMode == null)
				cb_getCaptureMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCaptureMode);
			return cb_getCaptureMode;
		}

		static IntPtr n_GetCaptureMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CaptureMode);
		}
#pragma warning restore 0169

		static Delegate cb_setCaptureMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCaptureMode_Ljava_lang_String_Handler ()
		{
			if (cb_setCaptureMode_Ljava_lang_String_ == null)
				cb_setCaptureMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCaptureMode_Ljava_lang_String_);
			return cb_setCaptureMode_Ljava_lang_String_;
		}

		static void n_SetCaptureMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CaptureMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCaptureMode;
		static IntPtr id_setCaptureMode_Ljava_lang_String_;
		public virtual unsafe string CaptureMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getCaptureMode' and count(parameter)=0]"
			[Register ("getCaptureMode", "()Ljava/lang/String;", "GetGetCaptureModeHandler")]
			get {
				if (id_getCaptureMode == IntPtr.Zero)
					id_getCaptureMode = JNIEnv.GetMethodID (class_ref, "getCaptureMode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCaptureMode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCaptureMode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setCaptureMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCaptureMode", "(Ljava/lang/String;)V", "GetSetCaptureMode_Ljava_lang_String_Handler")]
			set {
				if (id_setCaptureMode_Ljava_lang_String_ == IntPtr.Zero)
					id_setCaptureMode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCaptureMode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCaptureMode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCaptureMode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getColorSpace;
#pragma warning disable 0169
		static Delegate GetGetColorSpaceHandler ()
		{
			if (cb_getColorSpace == null)
				cb_getColorSpace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColorSpace);
			return cb_getColorSpace;
		}

		static IntPtr n_GetColorSpace (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ColorSpace);
		}
#pragma warning restore 0169

		static Delegate cb_setColorSpace_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetColorSpace_Ljava_lang_String_Handler ()
		{
			if (cb_setColorSpace_Ljava_lang_String_ == null)
				cb_setColorSpace_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorSpace_Ljava_lang_String_);
			return cb_setColorSpace_Ljava_lang_String_;
		}

		static void n_SetColorSpace_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ColorSpace = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getColorSpace;
		static IntPtr id_setColorSpace_Ljava_lang_String_;
		public virtual unsafe string ColorSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getColorSpace' and count(parameter)=0]"
			[Register ("getColorSpace", "()Ljava/lang/String;", "GetGetColorSpaceHandler")]
			get {
				if (id_getColorSpace == IntPtr.Zero)
					id_getColorSpace = JNIEnv.GetMethodID (class_ref, "getColorSpace", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getColorSpace), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorSpace", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setColorSpace' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setColorSpace", "(Ljava/lang/String;)V", "GetSetColorSpace_Ljava_lang_String_Handler")]
			set {
				if (id_setColorSpace_Ljava_lang_String_ == IntPtr.Zero)
					id_setColorSpace_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setColorSpace", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setColorSpace_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorSpace", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDateTime;
#pragma warning disable 0169
		static Delegate GetGetDateTimeHandler ()
		{
			if (cb_getDateTime == null)
				cb_getDateTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateTime);
			return cb_getDateTime;
		}

		static IntPtr n_GetDateTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DateTime);
		}
#pragma warning restore 0169

		static Delegate cb_setDateTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDateTime_Ljava_lang_String_Handler ()
		{
			if (cb_setDateTime_Ljava_lang_String_ == null)
				cb_setDateTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDateTime_Ljava_lang_String_);
			return cb_setDateTime_Ljava_lang_String_;
		}

		static void n_SetDateTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DateTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDateTime;
		static IntPtr id_setDateTime_Ljava_lang_String_;
		public virtual unsafe string DateTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getDateTime' and count(parameter)=0]"
			[Register ("getDateTime", "()Ljava/lang/String;", "GetGetDateTimeHandler")]
			get {
				if (id_getDateTime == IntPtr.Zero)
					id_getDateTime = JNIEnv.GetMethodID (class_ref, "getDateTime", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDateTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setDateTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDateTime", "(Ljava/lang/String;)V", "GetSetDateTime_Ljava_lang_String_Handler")]
			set {
				if (id_setDateTime_Ljava_lang_String_ == IntPtr.Zero)
					id_setDateTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateTime", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDateTime_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDateTime", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDateTimeDigitized;
#pragma warning disable 0169
		static Delegate GetGetDateTimeDigitizedHandler ()
		{
			if (cb_getDateTimeDigitized == null)
				cb_getDateTimeDigitized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateTimeDigitized);
			return cb_getDateTimeDigitized;
		}

		static IntPtr n_GetDateTimeDigitized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DateTimeDigitized);
		}
#pragma warning restore 0169

		static Delegate cb_setDateTimeDigitized_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDateTimeDigitized_Ljava_lang_String_Handler ()
		{
			if (cb_setDateTimeDigitized_Ljava_lang_String_ == null)
				cb_setDateTimeDigitized_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDateTimeDigitized_Ljava_lang_String_);
			return cb_setDateTimeDigitized_Ljava_lang_String_;
		}

		static void n_SetDateTimeDigitized_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DateTimeDigitized = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDateTimeDigitized;
		static IntPtr id_setDateTimeDigitized_Ljava_lang_String_;
		public virtual unsafe string DateTimeDigitized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getDateTimeDigitized' and count(parameter)=0]"
			[Register ("getDateTimeDigitized", "()Ljava/lang/String;", "GetGetDateTimeDigitizedHandler")]
			get {
				if (id_getDateTimeDigitized == IntPtr.Zero)
					id_getDateTimeDigitized = JNIEnv.GetMethodID (class_ref, "getDateTimeDigitized", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDateTimeDigitized), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateTimeDigitized", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setDateTimeDigitized' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDateTimeDigitized", "(Ljava/lang/String;)V", "GetSetDateTimeDigitized_Ljava_lang_String_Handler")]
			set {
				if (id_setDateTimeDigitized_Ljava_lang_String_ == IntPtr.Zero)
					id_setDateTimeDigitized_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateTimeDigitized", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDateTimeDigitized_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDateTimeDigitized", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDateTimeOriginal;
#pragma warning disable 0169
		static Delegate GetGetDateTimeOriginalHandler ()
		{
			if (cb_getDateTimeOriginal == null)
				cb_getDateTimeOriginal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateTimeOriginal);
			return cb_getDateTimeOriginal;
		}

		static IntPtr n_GetDateTimeOriginal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DateTimeOriginal);
		}
#pragma warning restore 0169

		static Delegate cb_setDateTimeOriginal_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDateTimeOriginal_Ljava_lang_String_Handler ()
		{
			if (cb_setDateTimeOriginal_Ljava_lang_String_ == null)
				cb_setDateTimeOriginal_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDateTimeOriginal_Ljava_lang_String_);
			return cb_setDateTimeOriginal_Ljava_lang_String_;
		}

		static void n_SetDateTimeOriginal_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DateTimeOriginal = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDateTimeOriginal;
		static IntPtr id_setDateTimeOriginal_Ljava_lang_String_;
		public virtual unsafe string DateTimeOriginal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getDateTimeOriginal' and count(parameter)=0]"
			[Register ("getDateTimeOriginal", "()Ljava/lang/String;", "GetGetDateTimeOriginalHandler")]
			get {
				if (id_getDateTimeOriginal == IntPtr.Zero)
					id_getDateTimeOriginal = JNIEnv.GetMethodID (class_ref, "getDateTimeOriginal", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDateTimeOriginal), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateTimeOriginal", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setDateTimeOriginal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDateTimeOriginal", "(Ljava/lang/String;)V", "GetSetDateTimeOriginal_Ljava_lang_String_Handler")]
			set {
				if (id_setDateTimeOriginal_Ljava_lang_String_ == IntPtr.Zero)
					id_setDateTimeOriginal_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateTimeOriginal", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDateTimeOriginal_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDateTimeOriginal", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExposureMode;
#pragma warning disable 0169
		static Delegate GetGetExposureModeHandler ()
		{
			if (cb_getExposureMode == null)
				cb_getExposureMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExposureMode);
			return cb_getExposureMode;
		}

		static IntPtr n_GetExposureMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExposureMode);
		}
#pragma warning restore 0169

		static Delegate cb_setExposureMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExposureMode_Ljava_lang_String_Handler ()
		{
			if (cb_setExposureMode_Ljava_lang_String_ == null)
				cb_setExposureMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExposureMode_Ljava_lang_String_);
			return cb_setExposureMode_Ljava_lang_String_;
		}

		static void n_SetExposureMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExposureMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExposureMode;
		static IntPtr id_setExposureMode_Ljava_lang_String_;
		public virtual unsafe string ExposureMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getExposureMode' and count(parameter)=0]"
			[Register ("getExposureMode", "()Ljava/lang/String;", "GetGetExposureModeHandler")]
			get {
				if (id_getExposureMode == IntPtr.Zero)
					id_getExposureMode = JNIEnv.GetMethodID (class_ref, "getExposureMode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getExposureMode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExposureMode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setExposureMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExposureMode", "(Ljava/lang/String;)V", "GetSetExposureMode_Ljava_lang_String_Handler")]
			set {
				if (id_setExposureMode_Ljava_lang_String_ == IntPtr.Zero)
					id_setExposureMode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExposureMode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setExposureMode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExposureMode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExposureProgram;
#pragma warning disable 0169
		static Delegate GetGetExposureProgramHandler ()
		{
			if (cb_getExposureProgram == null)
				cb_getExposureProgram = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExposureProgram);
			return cb_getExposureProgram;
		}

		static IntPtr n_GetExposureProgram (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExposureProgram);
		}
#pragma warning restore 0169

		static Delegate cb_setExposureProgram_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExposureProgram_Ljava_lang_String_Handler ()
		{
			if (cb_setExposureProgram_Ljava_lang_String_ == null)
				cb_setExposureProgram_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExposureProgram_Ljava_lang_String_);
			return cb_setExposureProgram_Ljava_lang_String_;
		}

		static void n_SetExposureProgram_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExposureProgram = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExposureProgram;
		static IntPtr id_setExposureProgram_Ljava_lang_String_;
		public virtual unsafe string ExposureProgram {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getExposureProgram' and count(parameter)=0]"
			[Register ("getExposureProgram", "()Ljava/lang/String;", "GetGetExposureProgramHandler")]
			get {
				if (id_getExposureProgram == IntPtr.Zero)
					id_getExposureProgram = JNIEnv.GetMethodID (class_ref, "getExposureProgram", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getExposureProgram), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExposureProgram", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setExposureProgram' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExposureProgram", "(Ljava/lang/String;)V", "GetSetExposureProgram_Ljava_lang_String_Handler")]
			set {
				if (id_setExposureProgram_Ljava_lang_String_ == IntPtr.Zero)
					id_setExposureProgram_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExposureProgram", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setExposureProgram_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExposureProgram", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExposureTime;
#pragma warning disable 0169
		static Delegate GetGetExposureTimeHandler ()
		{
			if (cb_getExposureTime == null)
				cb_getExposureTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExposureTime);
			return cb_getExposureTime;
		}

		static IntPtr n_GetExposureTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExposureTime);
		}
#pragma warning restore 0169

		static Delegate cb_setExposureTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExposureTime_Ljava_lang_String_Handler ()
		{
			if (cb_setExposureTime_Ljava_lang_String_ == null)
				cb_setExposureTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExposureTime_Ljava_lang_String_);
			return cb_setExposureTime_Ljava_lang_String_;
		}

		static void n_SetExposureTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExposureTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExposureTime;
		static IntPtr id_setExposureTime_Ljava_lang_String_;
		public virtual unsafe string ExposureTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getExposureTime' and count(parameter)=0]"
			[Register ("getExposureTime", "()Ljava/lang/String;", "GetGetExposureTimeHandler")]
			get {
				if (id_getExposureTime == IntPtr.Zero)
					id_getExposureTime = JNIEnv.GetMethodID (class_ref, "getExposureTime", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getExposureTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExposureTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setExposureTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExposureTime", "(Ljava/lang/String;)V", "GetSetExposureTime_Ljava_lang_String_Handler")]
			set {
				if (id_setExposureTime_Ljava_lang_String_ == IntPtr.Zero)
					id_setExposureTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExposureTime", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setExposureTime_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExposureTime", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFlash;
#pragma warning disable 0169
		static Delegate GetGetFlashHandler ()
		{
			if (cb_getFlash == null)
				cb_getFlash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFlash);
			return cb_getFlash;
		}

		static IntPtr n_GetFlash (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Flash);
		}
#pragma warning restore 0169

		static Delegate cb_setFlash_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFlash_Ljava_lang_String_Handler ()
		{
			if (cb_setFlash_Ljava_lang_String_ == null)
				cb_setFlash_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFlash_Ljava_lang_String_);
			return cb_setFlash_Ljava_lang_String_;
		}

		static void n_SetFlash_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Flash = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFlash;
		static IntPtr id_setFlash_Ljava_lang_String_;
		public virtual unsafe string Flash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getFlash' and count(parameter)=0]"
			[Register ("getFlash", "()Ljava/lang/String;", "GetGetFlashHandler")]
			get {
				if (id_getFlash == IntPtr.Zero)
					id_getFlash = JNIEnv.GetMethodID (class_ref, "getFlash", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFlash), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlash", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setFlash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFlash", "(Ljava/lang/String;)V", "GetSetFlash_Ljava_lang_String_Handler")]
			set {
				if (id_setFlash_Ljava_lang_String_ == IntPtr.Zero)
					id_setFlash_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFlash", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFlash_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFlash", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFocalLength;
#pragma warning disable 0169
		static Delegate GetGetFocalLengthHandler ()
		{
			if (cb_getFocalLength == null)
				cb_getFocalLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocalLength);
			return cb_getFocalLength;
		}

		static IntPtr n_GetFocalLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FocalLength);
		}
#pragma warning restore 0169

		static Delegate cb_setFocalLength_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFocalLength_Ljava_lang_String_Handler ()
		{
			if (cb_setFocalLength_Ljava_lang_String_ == null)
				cb_setFocalLength_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFocalLength_Ljava_lang_String_);
			return cb_setFocalLength_Ljava_lang_String_;
		}

		static void n_SetFocalLength_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FocalLength = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFocalLength;
		static IntPtr id_setFocalLength_Ljava_lang_String_;
		public virtual unsafe string FocalLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getFocalLength' and count(parameter)=0]"
			[Register ("getFocalLength", "()Ljava/lang/String;", "GetGetFocalLengthHandler")]
			get {
				if (id_getFocalLength == IntPtr.Zero)
					id_getFocalLength = JNIEnv.GetMethodID (class_ref, "getFocalLength", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFocalLength), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFocalLength", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setFocalLength' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFocalLength", "(Ljava/lang/String;)V", "GetSetFocalLength_Ljava_lang_String_Handler")]
			set {
				if (id_setFocalLength_Ljava_lang_String_ == IntPtr.Zero)
					id_setFocalLength_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFocalLength", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFocalLength_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFocalLength", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getGpsTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetGpsTimeStampHandler ()
		{
			if (cb_getGpsTimeStamp == null)
				cb_getGpsTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGpsTimeStamp);
			return cb_getGpsTimeStamp;
		}

		static IntPtr n_GetGpsTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GpsTimeStamp);
		}
#pragma warning restore 0169

		static Delegate cb_setGpsTimeStamp_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGpsTimeStamp_Ljava_lang_String_Handler ()
		{
			if (cb_setGpsTimeStamp_Ljava_lang_String_ == null)
				cb_setGpsTimeStamp_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGpsTimeStamp_Ljava_lang_String_);
			return cb_setGpsTimeStamp_Ljava_lang_String_;
		}

		static void n_SetGpsTimeStamp_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GpsTimeStamp = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGpsTimeStamp;
		static IntPtr id_setGpsTimeStamp_Ljava_lang_String_;
		public virtual unsafe string GpsTimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getGpsTimeStamp' and count(parameter)=0]"
			[Register ("getGpsTimeStamp", "()Ljava/lang/String;", "GetGetGpsTimeStampHandler")]
			get {
				if (id_getGpsTimeStamp == IntPtr.Zero)
					id_getGpsTimeStamp = JNIEnv.GetMethodID (class_ref, "getGpsTimeStamp", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getGpsTimeStamp), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGpsTimeStamp", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setGpsTimeStamp' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGpsTimeStamp", "(Ljava/lang/String;)V", "GetSetGpsTimeStamp_Ljava_lang_String_Handler")]
			set {
				if (id_setGpsTimeStamp_Ljava_lang_String_ == IntPtr.Zero)
					id_setGpsTimeStamp_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGpsTimeStamp", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setGpsTimeStamp_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGpsTimeStamp", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeight);
			return cb_getHeight;
		}

		static IntPtr n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Height);
		}
#pragma warning restore 0169

		static Delegate cb_setHeight_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetHeight_Ljava_lang_Integer_Handler ()
		{
			if (cb_setHeight_Ljava_lang_Integer_ == null)
				cb_setHeight_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeight_Ljava_lang_Integer_);
			return cb_setHeight_Ljava_lang_Integer_;
		}

		static void n_SetHeight_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Height = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		static IntPtr id_setHeight_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()Ljava/lang/Integer;", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getHeight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setHeight", "(Ljava/lang/Integer;)V", "GetSetHeight_Ljava_lang_Integer_Handler")]
			set {
				if (id_setHeight_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setHeight_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setHeight", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHeight_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeight", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIsoSpeedRatings;
#pragma warning disable 0169
		static Delegate GetGetIsoSpeedRatingsHandler ()
		{
			if (cb_getIsoSpeedRatings == null)
				cb_getIsoSpeedRatings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIsoSpeedRatings);
			return cb_getIsoSpeedRatings;
		}

		static IntPtr n_GetIsoSpeedRatings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IsoSpeedRatings);
		}
#pragma warning restore 0169

		static Delegate cb_setIsoSpeedRatings_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIsoSpeedRatings_Ljava_lang_String_Handler ()
		{
			if (cb_setIsoSpeedRatings_Ljava_lang_String_ == null)
				cb_setIsoSpeedRatings_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIsoSpeedRatings_Ljava_lang_String_);
			return cb_setIsoSpeedRatings_Ljava_lang_String_;
		}

		static void n_SetIsoSpeedRatings_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsoSpeedRatings = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIsoSpeedRatings;
		static IntPtr id_setIsoSpeedRatings_Ljava_lang_String_;
		public virtual unsafe string IsoSpeedRatings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getIsoSpeedRatings' and count(parameter)=0]"
			[Register ("getIsoSpeedRatings", "()Ljava/lang/String;", "GetGetIsoSpeedRatingsHandler")]
			get {
				if (id_getIsoSpeedRatings == IntPtr.Zero)
					id_getIsoSpeedRatings = JNIEnv.GetMethodID (class_ref, "getIsoSpeedRatings", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIsoSpeedRatings), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsoSpeedRatings", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setIsoSpeedRatings' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIsoSpeedRatings", "(Ljava/lang/String;)V", "GetSetIsoSpeedRatings_Ljava_lang_String_Handler")]
			set {
				if (id_setIsoSpeedRatings_Ljava_lang_String_ == IntPtr.Zero)
					id_setIsoSpeedRatings_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIsoSpeedRatings", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIsoSpeedRatings_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsoSpeedRatings", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Location);
		}
#pragma warning restore 0169

		static Delegate cb_setLocation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Ljava_lang_String_Handler ()
		{
			if (cb_setLocation_Ljava_lang_String_ == null)
				cb_setLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Ljava_lang_String_);
			return cb_setLocation_Ljava_lang_String_;
		}

		static void n_SetLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Location = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Ljava_lang_String_;
		public virtual unsafe string Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Ljava/lang/String;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocation", "(Ljava/lang/String;)V", "GetSetLocation_Ljava_lang_String_Handler")]
			set {
				if (id_setLocation_Ljava_lang_String_ == IntPtr.Zero)
					id_setLocation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLocation_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMake;
#pragma warning disable 0169
		static Delegate GetGetMakeHandler ()
		{
			if (cb_getMake == null)
				cb_getMake = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMake);
			return cb_getMake;
		}

		static IntPtr n_GetMake (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Make);
		}
#pragma warning restore 0169

		static Delegate cb_setMake_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMake_Ljava_lang_String_Handler ()
		{
			if (cb_setMake_Ljava_lang_String_ == null)
				cb_setMake_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMake_Ljava_lang_String_);
			return cb_setMake_Ljava_lang_String_;
		}

		static void n_SetMake_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Make = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMake;
		static IntPtr id_setMake_Ljava_lang_String_;
		public virtual unsafe string Make {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getMake' and count(parameter)=0]"
			[Register ("getMake", "()Ljava/lang/String;", "GetGetMakeHandler")]
			get {
				if (id_getMake == IntPtr.Zero)
					id_getMake = JNIEnv.GetMethodID (class_ref, "getMake", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMake), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMake", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setMake' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMake", "(Ljava/lang/String;)V", "GetSetMake_Ljava_lang_String_Handler")]
			set {
				if (id_setMake_Ljava_lang_String_ == IntPtr.Zero)
					id_setMake_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMake", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMake_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMake", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMeteringMode;
#pragma warning disable 0169
		static Delegate GetGetMeteringModeHandler ()
		{
			if (cb_getMeteringMode == null)
				cb_getMeteringMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeteringMode);
			return cb_getMeteringMode;
		}

		static IntPtr n_GetMeteringMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MeteringMode);
		}
#pragma warning restore 0169

		static Delegate cb_setMeteringMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMeteringMode_Ljava_lang_String_Handler ()
		{
			if (cb_setMeteringMode_Ljava_lang_String_ == null)
				cb_setMeteringMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMeteringMode_Ljava_lang_String_);
			return cb_setMeteringMode_Ljava_lang_String_;
		}

		static void n_SetMeteringMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MeteringMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMeteringMode;
		static IntPtr id_setMeteringMode_Ljava_lang_String_;
		public virtual unsafe string MeteringMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getMeteringMode' and count(parameter)=0]"
			[Register ("getMeteringMode", "()Ljava/lang/String;", "GetGetMeteringModeHandler")]
			get {
				if (id_getMeteringMode == IntPtr.Zero)
					id_getMeteringMode = JNIEnv.GetMethodID (class_ref, "getMeteringMode", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMeteringMode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMeteringMode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setMeteringMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMeteringMode", "(Ljava/lang/String;)V", "GetSetMeteringMode_Ljava_lang_String_Handler")]
			set {
				if (id_setMeteringMode_Ljava_lang_String_ == IntPtr.Zero)
					id_setMeteringMode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMeteringMode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMeteringMode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMeteringMode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getModel;
#pragma warning disable 0169
		static Delegate GetGetModelHandler ()
		{
			if (cb_getModel == null)
				cb_getModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModel);
			return cb_getModel;
		}

		static IntPtr n_GetModel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Model);
		}
#pragma warning restore 0169

		static Delegate cb_setModel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetModel_Ljava_lang_String_Handler ()
		{
			if (cb_setModel_Ljava_lang_String_ == null)
				cb_setModel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetModel_Ljava_lang_String_);
			return cb_setModel_Ljava_lang_String_;
		}

		static void n_SetModel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Model = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getModel;
		static IntPtr id_setModel_Ljava_lang_String_;
		public virtual unsafe string Model {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getModel' and count(parameter)=0]"
			[Register ("getModel", "()Ljava/lang/String;", "GetGetModelHandler")]
			get {
				if (id_getModel == IntPtr.Zero)
					id_getModel = JNIEnv.GetMethodID (class_ref, "getModel", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getModel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setModel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setModel", "(Ljava/lang/String;)V", "GetSetModel_Ljava_lang_String_Handler")]
			set {
				if (id_setModel_Ljava_lang_String_ == IntPtr.Zero)
					id_setModel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setModel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setModel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setModel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrientation);
			return cb_getOrientation;
		}

		static IntPtr n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Orientation);
		}
#pragma warning restore 0169

		static Delegate cb_setOrientation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOrientation_Ljava_lang_String_Handler ()
		{
			if (cb_setOrientation_Ljava_lang_String_ == null)
				cb_setOrientation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrientation_Ljava_lang_String_);
			return cb_setOrientation_Ljava_lang_String_;
		}

		static void n_SetOrientation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Orientation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation;
		static IntPtr id_setOrientation_Ljava_lang_String_;
		public virtual unsafe string Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()Ljava/lang/String;", "GetGetOrientationHandler")]
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOrientation), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOrientation", "(Ljava/lang/String;)V", "GetSetOrientation_Ljava_lang_String_Handler")]
			set {
				if (id_setOrientation_Ljava_lang_String_ == IntPtr.Zero)
					id_setOrientation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOrientation", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOrientation_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientation", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResolutionUnit;
#pragma warning disable 0169
		static Delegate GetGetResolutionUnitHandler ()
		{
			if (cb_getResolutionUnit == null)
				cb_getResolutionUnit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResolutionUnit);
			return cb_getResolutionUnit;
		}

		static IntPtr n_GetResolutionUnit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResolutionUnit);
		}
#pragma warning restore 0169

		static Delegate cb_setResolutionUnit_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResolutionUnit_Ljava_lang_String_Handler ()
		{
			if (cb_setResolutionUnit_Ljava_lang_String_ == null)
				cb_setResolutionUnit_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResolutionUnit_Ljava_lang_String_);
			return cb_setResolutionUnit_Ljava_lang_String_;
		}

		static void n_SetResolutionUnit_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResolutionUnit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResolutionUnit;
		static IntPtr id_setResolutionUnit_Ljava_lang_String_;
		public virtual unsafe string ResolutionUnit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getResolutionUnit' and count(parameter)=0]"
			[Register ("getResolutionUnit", "()Ljava/lang/String;", "GetGetResolutionUnitHandler")]
			get {
				if (id_getResolutionUnit == IntPtr.Zero)
					id_getResolutionUnit = JNIEnv.GetMethodID (class_ref, "getResolutionUnit", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getResolutionUnit), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResolutionUnit", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setResolutionUnit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResolutionUnit", "(Ljava/lang/String;)V", "GetSetResolutionUnit_Ljava_lang_String_Handler")]
			set {
				if (id_setResolutionUnit_Ljava_lang_String_ == IntPtr.Zero)
					id_setResolutionUnit_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResolutionUnit", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setResolutionUnit_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResolutionUnit", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSensingMethod;
#pragma warning disable 0169
		static Delegate GetGetSensingMethodHandler ()
		{
			if (cb_getSensingMethod == null)
				cb_getSensingMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSensingMethod);
			return cb_getSensingMethod;
		}

		static IntPtr n_GetSensingMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SensingMethod);
		}
#pragma warning restore 0169

		static Delegate cb_setSensingMethod_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSensingMethod_Ljava_lang_String_Handler ()
		{
			if (cb_setSensingMethod_Ljava_lang_String_ == null)
				cb_setSensingMethod_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSensingMethod_Ljava_lang_String_);
			return cb_setSensingMethod_Ljava_lang_String_;
		}

		static void n_SetSensingMethod_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SensingMethod = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSensingMethod;
		static IntPtr id_setSensingMethod_Ljava_lang_String_;
		public virtual unsafe string SensingMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getSensingMethod' and count(parameter)=0]"
			[Register ("getSensingMethod", "()Ljava/lang/String;", "GetGetSensingMethodHandler")]
			get {
				if (id_getSensingMethod == IntPtr.Zero)
					id_getSensingMethod = JNIEnv.GetMethodID (class_ref, "getSensingMethod", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSensingMethod), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSensingMethod", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setSensingMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSensingMethod", "(Ljava/lang/String;)V", "GetSetSensingMethod_Ljava_lang_String_Handler")]
			set {
				if (id_setSensingMethod_Ljava_lang_String_ == IntPtr.Zero)
					id_setSensingMethod_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSensingMethod", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSensingMethod_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSensingMethod", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSharpness;
#pragma warning disable 0169
		static Delegate GetGetSharpnessHandler ()
		{
			if (cb_getSharpness == null)
				cb_getSharpness = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSharpness);
			return cb_getSharpness;
		}

		static IntPtr n_GetSharpness (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Sharpness);
		}
#pragma warning restore 0169

		static Delegate cb_setSharpness_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSharpness_Ljava_lang_String_Handler ()
		{
			if (cb_setSharpness_Ljava_lang_String_ == null)
				cb_setSharpness_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSharpness_Ljava_lang_String_);
			return cb_setSharpness_Ljava_lang_String_;
		}

		static void n_SetSharpness_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Sharpness = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSharpness;
		static IntPtr id_setSharpness_Ljava_lang_String_;
		public virtual unsafe string Sharpness {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getSharpness' and count(parameter)=0]"
			[Register ("getSharpness", "()Ljava/lang/String;", "GetGetSharpnessHandler")]
			get {
				if (id_getSharpness == IntPtr.Zero)
					id_getSharpness = JNIEnv.GetMethodID (class_ref, "getSharpness", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSharpness), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSharpness", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setSharpness' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSharpness", "(Ljava/lang/String;)V", "GetSetSharpness_Ljava_lang_String_Handler")]
			set {
				if (id_setSharpness_Ljava_lang_String_ == IntPtr.Zero)
					id_setSharpness_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSharpness", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSharpness_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSharpness", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSoftware;
#pragma warning disable 0169
		static Delegate GetGetSoftwareHandler ()
		{
			if (cb_getSoftware == null)
				cb_getSoftware = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSoftware);
			return cb_getSoftware;
		}

		static IntPtr n_GetSoftware (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Software);
		}
#pragma warning restore 0169

		static Delegate cb_setSoftware_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSoftware_Ljava_lang_String_Handler ()
		{
			if (cb_setSoftware_Ljava_lang_String_ == null)
				cb_setSoftware_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSoftware_Ljava_lang_String_);
			return cb_setSoftware_Ljava_lang_String_;
		}

		static void n_SetSoftware_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Software = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSoftware;
		static IntPtr id_setSoftware_Ljava_lang_String_;
		public virtual unsafe string Software {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getSoftware' and count(parameter)=0]"
			[Register ("getSoftware", "()Ljava/lang/String;", "GetGetSoftwareHandler")]
			get {
				if (id_getSoftware == IntPtr.Zero)
					id_getSoftware = JNIEnv.GetMethodID (class_ref, "getSoftware", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSoftware), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSoftware", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setSoftware' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSoftware", "(Ljava/lang/String;)V", "GetSetSoftware_Ljava_lang_String_Handler")]
			set {
				if (id_setSoftware_Ljava_lang_String_ == IntPtr.Zero)
					id_setSoftware_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSoftware", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSoftware_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSoftware", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWhiteBalance;
#pragma warning disable 0169
		static Delegate GetGetWhiteBalanceHandler ()
		{
			if (cb_getWhiteBalance == null)
				cb_getWhiteBalance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWhiteBalance);
			return cb_getWhiteBalance;
		}

		static IntPtr n_GetWhiteBalance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.WhiteBalance);
		}
#pragma warning restore 0169

		static Delegate cb_setWhiteBalance_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWhiteBalance_Ljava_lang_String_Handler ()
		{
			if (cb_setWhiteBalance_Ljava_lang_String_ == null)
				cb_setWhiteBalance_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWhiteBalance_Ljava_lang_String_);
			return cb_setWhiteBalance_Ljava_lang_String_;
		}

		static void n_SetWhiteBalance_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WhiteBalance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWhiteBalance;
		static IntPtr id_setWhiteBalance_Ljava_lang_String_;
		public virtual unsafe string WhiteBalance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getWhiteBalance' and count(parameter)=0]"
			[Register ("getWhiteBalance", "()Ljava/lang/String;", "GetGetWhiteBalanceHandler")]
			get {
				if (id_getWhiteBalance == IntPtr.Zero)
					id_getWhiteBalance = JNIEnv.GetMethodID (class_ref, "getWhiteBalance", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getWhiteBalance), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWhiteBalance", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setWhiteBalance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setWhiteBalance", "(Ljava/lang/String;)V", "GetSetWhiteBalance_Ljava_lang_String_Handler")]
			set {
				if (id_setWhiteBalance_Ljava_lang_String_ == IntPtr.Zero)
					id_setWhiteBalance_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setWhiteBalance", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWhiteBalance_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWhiteBalance", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWidth);
			return cb_getWidth;
		}

		static IntPtr n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Width);
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetWidth_Ljava_lang_Integer_Handler ()
		{
			if (cb_setWidth_Ljava_lang_Integer_ == null)
				cb_setWidth_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWidth_Ljava_lang_Integer_);
			return cb_setWidth_Ljava_lang_Integer_;
		}

		static void n_SetWidth_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()Ljava/lang/Integer;", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getWidth), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setWidth", "(Ljava/lang/Integer;)V", "GetSetWidth_Ljava_lang_Integer_Handler")]
			set {
				if (id_setWidth_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setWidth_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setWidth", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWidth_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getXResolution;
#pragma warning disable 0169
		static Delegate GetGetXResolutionHandler ()
		{
			if (cb_getXResolution == null)
				cb_getXResolution = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetXResolution);
			return cb_getXResolution;
		}

		static IntPtr n_GetXResolution (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.XResolution);
		}
#pragma warning restore 0169

		static Delegate cb_setXResolution_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetXResolution_Ljava_lang_String_Handler ()
		{
			if (cb_setXResolution_Ljava_lang_String_ == null)
				cb_setXResolution_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetXResolution_Ljava_lang_String_);
			return cb_setXResolution_Ljava_lang_String_;
		}

		static void n_SetXResolution_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.XResolution = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getXResolution;
		static IntPtr id_setXResolution_Ljava_lang_String_;
		public virtual unsafe string XResolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getXResolution' and count(parameter)=0]"
			[Register ("getXResolution", "()Ljava/lang/String;", "GetGetXResolutionHandler")]
			get {
				if (id_getXResolution == IntPtr.Zero)
					id_getXResolution = JNIEnv.GetMethodID (class_ref, "getXResolution", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getXResolution), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXResolution", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setXResolution' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setXResolution", "(Ljava/lang/String;)V", "GetSetXResolution_Ljava_lang_String_Handler")]
			set {
				if (id_setXResolution_Ljava_lang_String_ == IntPtr.Zero)
					id_setXResolution_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setXResolution", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setXResolution_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setXResolution", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getYResolution;
#pragma warning disable 0169
		static Delegate GetGetYResolutionHandler ()
		{
			if (cb_getYResolution == null)
				cb_getYResolution = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetYResolution);
			return cb_getYResolution;
		}

		static IntPtr n_GetYResolution (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.YResolution);
		}
#pragma warning restore 0169

		static Delegate cb_setYResolution_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetYResolution_Ljava_lang_String_Handler ()
		{
			if (cb_setYResolution_Ljava_lang_String_ == null)
				cb_setYResolution_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetYResolution_Ljava_lang_String_);
			return cb_setYResolution_Ljava_lang_String_;
		}

		static void n_SetYResolution_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.YResolution = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYResolution;
		static IntPtr id_setYResolution_Ljava_lang_String_;
		public virtual unsafe string YResolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='getYResolution' and count(parameter)=0]"
			[Register ("getYResolution", "()Ljava/lang/String;", "GetGetYResolutionHandler")]
			get {
				if (id_getYResolution == IntPtr.Zero)
					id_getYResolution = JNIEnv.GetMethodID (class_ref, "getYResolution", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getYResolution), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYResolution", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='setYResolution' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setYResolution", "(Ljava/lang/String;)V", "GetSetYResolution_Ljava_lang_String_Handler")]
			set {
				if (id_setYResolution_Ljava_lang_String_ == IntPtr.Zero)
					id_setYResolution_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setYResolution", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setYResolution_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYResolution", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_ImageProperties_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_ImageProperties_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_ImageProperties_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_ImageProperties_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_ImageProperties_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_ImageProperties_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_ImageProperties_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ImageProperties __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ImageProperties p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ImageProperties> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_ImageProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ImageProperties']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.ImageProperties']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/ImageProperties;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_ImageProperties_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.ImageProperties p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_ImageProperties_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_ImageProperties_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/ImageProperties;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_ImageProperties_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/ImageProperties;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
