using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/GetAccountEndpointResponse", DoNotGenerateAcw=true)]
	public partial class GetAccountEndpointResponse : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/GetAccountEndpointResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetAccountEndpointResponse); }
		}

		protected GetAccountEndpointResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/constructor[@name='GetAccountEndpointResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetAccountEndpointResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GetAccountEndpointResponse)) {
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

		static Delegate cb_getContentUrl;
#pragma warning disable 0169
		static Delegate GetGetContentUrlHandler ()
		{
			if (cb_getContentUrl == null)
				cb_getContentUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentUrl);
			return cb_getContentUrl;
		}

		static IntPtr n_GetContentUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setContentUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setContentUrl_Ljava_lang_String_ == null)
				cb_setContentUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentUrl_Ljava_lang_String_);
			return cb_setContentUrl_Ljava_lang_String_;
		}

		static void n_SetContentUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContentUrl;
		static IntPtr id_setContentUrl_Ljava_lang_String_;
		public virtual unsafe string ContentUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='getContentUrl' and count(parameter)=0]"
			[Register ("getContentUrl", "()Ljava/lang/String;", "GetGetContentUrlHandler")]
			get {
				if (id_getContentUrl == IntPtr.Zero)
					id_getContentUrl = JNIEnv.GetMethodID (class_ref, "getContentUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContentUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='setContentUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentUrl", "(Ljava/lang/String;)V", "GetSetContentUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setContentUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setContentUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCountryAtSignup;
#pragma warning disable 0169
		static Delegate GetGetCountryAtSignupHandler ()
		{
			if (cb_getCountryAtSignup == null)
				cb_getCountryAtSignup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountryAtSignup);
			return cb_getCountryAtSignup;
		}

		static IntPtr n_GetCountryAtSignup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CountryAtSignup);
		}
#pragma warning restore 0169

		static Delegate cb_setCountryAtSignup_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountryAtSignup_Ljava_lang_String_Handler ()
		{
			if (cb_setCountryAtSignup_Ljava_lang_String_ == null)
				cb_setCountryAtSignup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountryAtSignup_Ljava_lang_String_);
			return cb_setCountryAtSignup_Ljava_lang_String_;
		}

		static void n_SetCountryAtSignup_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CountryAtSignup = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCountryAtSignup;
		static IntPtr id_setCountryAtSignup_Ljava_lang_String_;
		public virtual unsafe string CountryAtSignup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='getCountryAtSignup' and count(parameter)=0]"
			[Register ("getCountryAtSignup", "()Ljava/lang/String;", "GetGetCountryAtSignupHandler")]
			get {
				if (id_getCountryAtSignup == IntPtr.Zero)
					id_getCountryAtSignup = JNIEnv.GetMethodID (class_ref, "getCountryAtSignup", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCountryAtSignup), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCountryAtSignup", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='setCountryAtSignup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCountryAtSignup", "(Ljava/lang/String;)V", "GetSetCountryAtSignup_Ljava_lang_String_Handler")]
			set {
				if (id_setCountryAtSignup_Ljava_lang_String_ == IntPtr.Zero)
					id_setCountryAtSignup_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCountryAtSignup", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCountryAtSignup_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCountryAtSignup", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isCustomerExists;
#pragma warning disable 0169
		static Delegate GetIsCustomerExistsHandler ()
		{
			if (cb_isCustomerExists == null)
				cb_isCustomerExists = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCustomerExists);
			return cb_isCustomerExists;
		}

		static bool n_IsCustomerExists (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CustomerExists;
		}
#pragma warning restore 0169

		static Delegate cb_setCustomerExists_Z;
#pragma warning disable 0169
		static Delegate GetSetCustomerExists_ZHandler ()
		{
			if (cb_setCustomerExists_Z == null)
				cb_setCustomerExists_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCustomerExists_Z);
			return cb_setCustomerExists_Z;
		}

		static void n_SetCustomerExists_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CustomerExists = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCustomerExists;
		static IntPtr id_setCustomerExists_Z;
		public virtual unsafe bool CustomerExists {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='isCustomerExists' and count(parameter)=0]"
			[Register ("isCustomerExists", "()Z", "GetIsCustomerExistsHandler")]
			get {
				if (id_isCustomerExists == IntPtr.Zero)
					id_isCustomerExists = JNIEnv.GetMethodID (class_ref, "isCustomerExists", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCustomerExists);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCustomerExists", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='setCustomerExists' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCustomerExists", "(Z)V", "GetSetCustomerExists_ZHandler")]
			set {
				if (id_setCustomerExists_Z == IntPtr.Zero)
					id_setCustomerExists_Z = JNIEnv.GetMethodID (class_ref, "setCustomerExists", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCustomerExists_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomerExists", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMarketplaceAtSignup;
#pragma warning disable 0169
		static Delegate GetGetMarketplaceAtSignupHandler ()
		{
			if (cb_getMarketplaceAtSignup == null)
				cb_getMarketplaceAtSignup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarketplaceAtSignup);
			return cb_getMarketplaceAtSignup;
		}

		static IntPtr n_GetMarketplaceAtSignup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MarketplaceAtSignup);
		}
#pragma warning restore 0169

		static Delegate cb_setMarketplaceAtSignup_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMarketplaceAtSignup_Ljava_lang_String_Handler ()
		{
			if (cb_setMarketplaceAtSignup_Ljava_lang_String_ == null)
				cb_setMarketplaceAtSignup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMarketplaceAtSignup_Ljava_lang_String_);
			return cb_setMarketplaceAtSignup_Ljava_lang_String_;
		}

		static void n_SetMarketplaceAtSignup_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarketplaceAtSignup = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMarketplaceAtSignup;
		static IntPtr id_setMarketplaceAtSignup_Ljava_lang_String_;
		public virtual unsafe string MarketplaceAtSignup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='getMarketplaceAtSignup' and count(parameter)=0]"
			[Register ("getMarketplaceAtSignup", "()Ljava/lang/String;", "GetGetMarketplaceAtSignupHandler")]
			get {
				if (id_getMarketplaceAtSignup == IntPtr.Zero)
					id_getMarketplaceAtSignup = JNIEnv.GetMethodID (class_ref, "getMarketplaceAtSignup", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMarketplaceAtSignup), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarketplaceAtSignup", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='setMarketplaceAtSignup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMarketplaceAtSignup", "(Ljava/lang/String;)V", "GetSetMarketplaceAtSignup_Ljava_lang_String_Handler")]
			set {
				if (id_setMarketplaceAtSignup_Ljava_lang_String_ == IntPtr.Zero)
					id_setMarketplaceAtSignup_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMarketplaceAtSignup", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMarketplaceAtSignup_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMarketplaceAtSignup", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMetadataUrl;
#pragma warning disable 0169
		static Delegate GetGetMetadataUrlHandler ()
		{
			if (cb_getMetadataUrl == null)
				cb_getMetadataUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadataUrl);
			return cb_getMetadataUrl;
		}

		static IntPtr n_GetMetadataUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MetadataUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setMetadataUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMetadataUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setMetadataUrl_Ljava_lang_String_ == null)
				cb_setMetadataUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMetadataUrl_Ljava_lang_String_);
			return cb_setMetadataUrl_Ljava_lang_String_;
		}

		static void n_SetMetadataUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MetadataUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMetadataUrl;
		static IntPtr id_setMetadataUrl_Ljava_lang_String_;
		public virtual unsafe string MetadataUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='getMetadataUrl' and count(parameter)=0]"
			[Register ("getMetadataUrl", "()Ljava/lang/String;", "GetGetMetadataUrlHandler")]
			get {
				if (id_getMetadataUrl == IntPtr.Zero)
					id_getMetadataUrl = JNIEnv.GetMethodID (class_ref, "getMetadataUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMetadataUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetadataUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='setMetadataUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMetadataUrl", "(Ljava/lang/String;)V", "GetSetMetadataUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setMetadataUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setMetadataUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMetadataUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMetadataUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMetadataUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRegion;
#pragma warning disable 0169
		static Delegate GetGetRegionHandler ()
		{
			if (cb_getRegion == null)
				cb_getRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegion);
			return cb_getRegion;
		}

		static IntPtr n_GetRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Region);
		}
#pragma warning restore 0169

		static Delegate cb_setRegion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRegion_Ljava_lang_String_Handler ()
		{
			if (cb_setRegion_Ljava_lang_String_ == null)
				cb_setRegion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRegion_Ljava_lang_String_);
			return cb_setRegion_Ljava_lang_String_;
		}

		static void n_SetRegion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Region = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRegion;
		static IntPtr id_setRegion_Ljava_lang_String_;
		public virtual unsafe string Region {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='getRegion' and count(parameter)=0]"
			[Register ("getRegion", "()Ljava/lang/String;", "GetGetRegionHandler")]
			get {
				if (id_getRegion == IntPtr.Zero)
					id_getRegion = JNIEnv.GetMethodID (class_ref, "getRegion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRegion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='setRegion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRegion", "(Ljava/lang/String;)V", "GetSetRegion_Ljava_lang_String_Handler")]
			set {
				if (id_setRegion_Ljava_lang_String_ == IntPtr.Zero)
					id_setRegion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRegion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRegion_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegion", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRetailUrl;
#pragma warning disable 0169
		static Delegate GetGetRetailUrlHandler ()
		{
			if (cb_getRetailUrl == null)
				cb_getRetailUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRetailUrl);
			return cb_getRetailUrl;
		}

		static IntPtr n_GetRetailUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RetailUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setRetailUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRetailUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setRetailUrl_Ljava_lang_String_ == null)
				cb_setRetailUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRetailUrl_Ljava_lang_String_);
			return cb_setRetailUrl_Ljava_lang_String_;
		}

		static void n_SetRetailUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RetailUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRetailUrl;
		static IntPtr id_setRetailUrl_Ljava_lang_String_;
		public virtual unsafe string RetailUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='getRetailUrl' and count(parameter)=0]"
			[Register ("getRetailUrl", "()Ljava/lang/String;", "GetGetRetailUrlHandler")]
			get {
				if (id_getRetailUrl == IntPtr.Zero)
					id_getRetailUrl = JNIEnv.GetMethodID (class_ref, "getRetailUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRetailUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetailUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='setRetailUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRetailUrl", "(Ljava/lang/String;)V", "GetSetRetailUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setRetailUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setRetailUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRetailUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRetailUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRetailUrl", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.GetAccountEndpointResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='GetAccountEndpointResponse']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveResponse']]"
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
