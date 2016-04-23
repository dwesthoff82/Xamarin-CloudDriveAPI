using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/ListChildrenRequest", DoNotGenerateAcw=true)]
	public partial class ListChildrenRequest : global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/ListChildrenRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ListChildrenRequest); }
		}

		protected ListChildrenRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/constructor[@name='ListChildrenRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ListChildrenRequest (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ListChildrenRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAssetMapping;
#pragma warning disable 0169
		static Delegate GetGetAssetMappingHandler ()
		{
			if (cb_getAssetMapping == null)
				cb_getAssetMapping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAssetMapping);
			return cb_getAssetMapping;
		}

		static IntPtr n_GetAssetMapping (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AssetMapping);
		}
#pragma warning restore 0169

		static Delegate cb_setAssetMapping_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAssetMapping_Ljava_lang_String_Handler ()
		{
			if (cb_setAssetMapping_Ljava_lang_String_ == null)
				cb_setAssetMapping_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAssetMapping_Ljava_lang_String_);
			return cb_setAssetMapping_Ljava_lang_String_;
		}

		static void n_SetAssetMapping_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AssetMapping = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAssetMapping;
		static IntPtr id_setAssetMapping_Ljava_lang_String_;
		public virtual unsafe string AssetMapping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='getAssetMapping' and count(parameter)=0]"
			[Register ("getAssetMapping", "()Ljava/lang/String;", "GetGetAssetMappingHandler")]
			get {
				if (id_getAssetMapping == IntPtr.Zero)
					id_getAssetMapping = JNIEnv.GetMethodID (class_ref, "getAssetMapping", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAssetMapping), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAssetMapping", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='setAssetMapping' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAssetMapping", "(Ljava/lang/String;)V", "GetSetAssetMapping_Ljava_lang_String_Handler")]
			set {
				if (id_setAssetMapping_Ljava_lang_String_ == IntPtr.Zero)
					id_setAssetMapping_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAssetMapping", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAssetMapping_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAssetMapping", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TempLink);
		}
#pragma warning restore 0169

		static Delegate cb_setTempLink_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetTempLink_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setTempLink_Ljava_lang_Boolean_ == null)
				cb_setTempLink_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTempLink_Ljava_lang_Boolean_);
			return cb_setTempLink_Ljava_lang_Boolean_;
		}

		static void n_SetTempLink_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TempLink = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTempLink;
		static IntPtr id_setTempLink_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean TempLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='getTempLink' and count(parameter)=0]"
			[Register ("getTempLink", "()Ljava/lang/Boolean;", "GetGetTempLinkHandler")]
			get {
				if (id_getTempLink == IntPtr.Zero)
					id_getTempLink = JNIEnv.GetMethodID (class_ref, "getTempLink", "()Ljava/lang/Boolean;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod  (Handle, id_getTempLink), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTempLink", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='setTempLink' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setTempLink", "(Ljava/lang/Boolean;)V", "GetSetTempLink_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setTempLink_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setTempLink_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setTempLink", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTempLink_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTempLink", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_withAssetMapping_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithAssetMapping_Ljava_lang_String_Handler ()
		{
			if (cb_withAssetMapping_Ljava_lang_String_ == null)
				cb_withAssetMapping_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAssetMapping_Ljava_lang_String_);
			return cb_withAssetMapping_Ljava_lang_String_;
		}

		static IntPtr n_WithAssetMapping_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAssetMapping (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAssetMapping_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='withAssetMapping' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withAssetMapping", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;", "GetWithAssetMapping_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListChildrenRequest WithAssetMapping (string p0)
		{
			if (id_withAssetMapping_Ljava_lang_String_ == IntPtr.Zero)
				id_withAssetMapping_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withAssetMapping", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallObjectMethod  (Handle, id_withAssetMapping_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAssetMapping", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withFields_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithFields_Ljava_lang_String_Handler ()
		{
			if (cb_withFields_Ljava_lang_String_ == null)
				cb_withFields_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithFields_Ljava_lang_String_);
			return cb_withFields_Ljava_lang_String_;
		}

		static IntPtr n_WithFields_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFields (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withFields_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='withFields' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withFields", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;", "GetWithFields_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListChildrenRequest WithFields (string p0)
		{
			if (id_withFields_Ljava_lang_String_ == IntPtr.Zero)
				id_withFields_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withFields", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallObjectMethod  (Handle, id_withFields_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFields", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withFilters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithFilters_Ljava_lang_String_Handler ()
		{
			if (cb_withFilters_Ljava_lang_String_ == null)
				cb_withFilters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithFilters_Ljava_lang_String_);
			return cb_withFilters_Ljava_lang_String_;
		}

		static IntPtr n_WithFilters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFilters (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withFilters_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='withFilters' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withFilters", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;", "GetWithFilters_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListChildrenRequest WithFilters (string p0)
		{
			if (id_withFilters_Ljava_lang_String_ == IntPtr.Zero)
				id_withFilters_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withFilters", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallObjectMethod  (Handle, id_withFilters_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFilters", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withLimit_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetWithLimit_Ljava_lang_Integer_Handler ()
		{
			if (cb_withLimit_Ljava_lang_Integer_ == null)
				cb_withLimit_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLimit_Ljava_lang_Integer_);
			return cb_withLimit_Ljava_lang_Integer_;
		}

		static IntPtr n_WithLimit_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLimit (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withLimit_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='withLimit' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("withLimit", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListChildrenRequest;", "GetWithLimit_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListChildrenRequest WithLimit (global::Java.Lang.Integer p0)
		{
			if (id_withLimit_Ljava_lang_Integer_ == IntPtr.Zero)
				id_withLimit_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "withLimit", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListChildrenRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallObjectMethod  (Handle, id_withLimit_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withLimit", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListChildrenRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOffset_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetWithOffset_Ljava_lang_Integer_Handler ()
		{
			if (cb_withOffset_Ljava_lang_Integer_ == null)
				cb_withOffset_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOffset_Ljava_lang_Integer_);
			return cb_withOffset_Ljava_lang_Integer_;
		}

		static IntPtr n_WithOffset_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOffset (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOffset_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='withOffset' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("withOffset", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListChildrenRequest;", "GetWithOffset_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListChildrenRequest WithOffset (global::Java.Lang.Integer p0)
		{
			if (id_withOffset_Ljava_lang_Integer_ == IntPtr.Zero)
				id_withOffset_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "withOffset", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListChildrenRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallObjectMethod  (Handle, id_withOffset_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOffset", "(Ljava/lang/Integer;)Lcom/amazon/clouddrive/model/ListChildrenRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withSort_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithSort_Ljava_lang_String_Handler ()
		{
			if (cb_withSort_Ljava_lang_String_ == null)
				cb_withSort_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSort_Ljava_lang_String_);
			return cb_withSort_Ljava_lang_String_;
		}

		static IntPtr n_WithSort_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSort (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSort_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='withSort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withSort", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;", "GetWithSort_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListChildrenRequest WithSort (string p0)
		{
			if (id_withSort_Ljava_lang_String_ == IntPtr.Zero)
				id_withSort_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withSort", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallObjectMethod  (Handle, id_withSort_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSort", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withStartToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithStartToken_Ljava_lang_String_Handler ()
		{
			if (cb_withStartToken_Ljava_lang_String_ == null)
				cb_withStartToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithStartToken_Ljava_lang_String_);
			return cb_withStartToken_Ljava_lang_String_;
		}

		static IntPtr n_WithStartToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithStartToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withStartToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='withStartToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withStartToken", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;", "GetWithStartToken_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListChildrenRequest WithStartToken (string p0)
		{
			if (id_withStartToken_Ljava_lang_String_ == IntPtr.Zero)
				id_withStartToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withStartToken", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallObjectMethod  (Handle, id_withStartToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withStartToken", "(Ljava/lang/String;)Lcom/amazon/clouddrive/model/ListChildrenRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withTempLink_Z;
#pragma warning disable 0169
		static Delegate GetWithTempLink_ZHandler ()
		{
			if (cb_withTempLink_Z == null)
				cb_withTempLink_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithTempLink_Z);
			return cb_withTempLink_Z;
		}

		static IntPtr n_WithTempLink_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Amazon.Clouddrive.Model.ListChildrenRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTempLink (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTempLink_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='ListChildrenRequest']/method[@name='withTempLink' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withTempLink", "(Z)Lcom/amazon/clouddrive/model/ListChildrenRequest;", "GetWithTempLink_ZHandler")]
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.ListChildrenRequest WithTempLink (bool p0)
		{
			if (id_withTempLink_Z == IntPtr.Zero)
				id_withTempLink_Z = JNIEnv.GetMethodID (class_ref, "withTempLink", "(Z)Lcom/amazon/clouddrive/model/ListChildrenRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallObjectMethod  (Handle, id_withTempLink_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ListChildrenRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTempLink", "(Z)Lcom/amazon/clouddrive/model/ListChildrenRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
