using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/PaginatedCloudDriveRequest", DoNotGenerateAcw=true)]
	public abstract partial class PaginatedCloudDriveRequest : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/PaginatedCloudDriveRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaginatedCloudDriveRequest); }
		}

		protected PaginatedCloudDriveRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/constructor[@name='PaginatedCloudDriveRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaginatedCloudDriveRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PaginatedCloudDriveRequest)) {
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

		static Delegate cb_getFields;
#pragma warning disable 0169
		static Delegate GetGetFieldsHandler ()
		{
			if (cb_getFields == null)
				cb_getFields = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFields);
			return cb_getFields;
		}

		static IntPtr n_GetFields (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Fields);
		}
#pragma warning restore 0169

		static Delegate cb_setFields_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFields_Ljava_lang_String_Handler ()
		{
			if (cb_setFields_Ljava_lang_String_ == null)
				cb_setFields_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFields_Ljava_lang_String_);
			return cb_setFields_Ljava_lang_String_;
		}

		static void n_SetFields_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Fields = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFields;
		static IntPtr id_setFields_Ljava_lang_String_;
		public virtual unsafe string Fields {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='getFields' and count(parameter)=0]"
			[Register ("getFields", "()Ljava/lang/String;", "GetGetFieldsHandler")]
			get {
				if (id_getFields == IntPtr.Zero)
					id_getFields = JNIEnv.GetMethodID (class_ref, "getFields", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFields), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFields", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='setFields' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFields", "(Ljava/lang/String;)V", "GetSetFields_Ljava_lang_String_Handler")]
			set {
				if (id_setFields_Ljava_lang_String_ == IntPtr.Zero)
					id_setFields_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFields", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFields_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFields", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFilters;
#pragma warning disable 0169
		static Delegate GetGetFiltersHandler ()
		{
			if (cb_getFilters == null)
				cb_getFilters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilters);
			return cb_getFilters;
		}

		static IntPtr n_GetFilters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Filters);
		}
#pragma warning restore 0169

		static Delegate cb_setFilters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFilters_Ljava_lang_String_Handler ()
		{
			if (cb_setFilters_Ljava_lang_String_ == null)
				cb_setFilters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilters_Ljava_lang_String_);
			return cb_setFilters_Ljava_lang_String_;
		}

		static void n_SetFilters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Filters = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFilters;
		static IntPtr id_setFilters_Ljava_lang_String_;
		public virtual unsafe string Filters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='getFilters' and count(parameter)=0]"
			[Register ("getFilters", "()Ljava/lang/String;", "GetGetFiltersHandler")]
			get {
				if (id_getFilters == IntPtr.Zero)
					id_getFilters = JNIEnv.GetMethodID (class_ref, "getFilters", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFilters), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilters", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='setFilters' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFilters", "(Ljava/lang/String;)V", "GetSetFilters_Ljava_lang_String_Handler")]
			set {
				if (id_setFilters_Ljava_lang_String_ == IntPtr.Zero)
					id_setFilters_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFilters", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFilters_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFilters", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLimit;
#pragma warning disable 0169
		static Delegate GetGetLimitHandler ()
		{
			if (cb_getLimit == null)
				cb_getLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLimit);
			return cb_getLimit;
		}

		static IntPtr n_GetLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Limit);
		}
#pragma warning restore 0169

		static Delegate cb_setLimit_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetLimit_Ljava_lang_Integer_Handler ()
		{
			if (cb_setLimit_Ljava_lang_Integer_ == null)
				cb_setLimit_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLimit_Ljava_lang_Integer_);
			return cb_setLimit_Ljava_lang_Integer_;
		}

		static void n_SetLimit_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Limit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLimit;
		static IntPtr id_setLimit_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='getLimit' and count(parameter)=0]"
			[Register ("getLimit", "()Ljava/lang/Integer;", "GetGetLimitHandler")]
			get {
				if (id_getLimit == IntPtr.Zero)
					id_getLimit = JNIEnv.GetMethodID (class_ref, "getLimit", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getLimit), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLimit", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='setLimit' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setLimit", "(Ljava/lang/Integer;)V", "GetSetLimit_Ljava_lang_Integer_Handler")]
			set {
				if (id_setLimit_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setLimit_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setLimit", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLimit_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLimit", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOffset);
			return cb_getOffset;
		}

		static IntPtr n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Offset);
		}
#pragma warning restore 0169

		static Delegate cb_setOffset_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetOffset_Ljava_lang_Integer_Handler ()
		{
			if (cb_setOffset_Ljava_lang_Integer_ == null)
				cb_setOffset_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOffset_Ljava_lang_Integer_);
			return cb_setOffset_Ljava_lang_Integer_;
		}

		static void n_SetOffset_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Offset = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOffset;
		static IntPtr id_setOffset_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()Ljava/lang/Integer;", "GetGetOffsetHandler")]
			get {
				if (id_getOffset == IntPtr.Zero)
					id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()Ljava/lang/Integer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod  (Handle, id_getOffset), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setOffset", "(Ljava/lang/Integer;)V", "GetSetOffset_Ljava_lang_Integer_Handler")]
			set {
				if (id_setOffset_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setOffset_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setOffset", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOffset_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOffset", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSort;
#pragma warning disable 0169
		static Delegate GetGetSortHandler ()
		{
			if (cb_getSort == null)
				cb_getSort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSort);
			return cb_getSort;
		}

		static IntPtr n_GetSort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Sort);
		}
#pragma warning restore 0169

		static Delegate cb_setSort_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSort_Ljava_lang_String_Handler ()
		{
			if (cb_setSort_Ljava_lang_String_ == null)
				cb_setSort_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSort_Ljava_lang_String_);
			return cb_setSort_Ljava_lang_String_;
		}

		static void n_SetSort_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Sort = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSort;
		static IntPtr id_setSort_Ljava_lang_String_;
		public virtual unsafe string Sort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='getSort' and count(parameter)=0]"
			[Register ("getSort", "()Ljava/lang/String;", "GetGetSortHandler")]
			get {
				if (id_getSort == IntPtr.Zero)
					id_getSort = JNIEnv.GetMethodID (class_ref, "getSort", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSort), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSort", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='setSort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSort", "(Ljava/lang/String;)V", "GetSetSort_Ljava_lang_String_Handler")]
			set {
				if (id_setSort_Ljava_lang_String_ == IntPtr.Zero)
					id_setSort_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSort", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSort_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSort", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStartToken;
#pragma warning disable 0169
		static Delegate GetGetStartTokenHandler ()
		{
			if (cb_getStartToken == null)
				cb_getStartToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartToken);
			return cb_getStartToken;
		}

		static IntPtr n_GetStartToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StartToken);
		}
#pragma warning restore 0169

		static Delegate cb_setStartToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStartToken_Ljava_lang_String_Handler ()
		{
			if (cb_setStartToken_Ljava_lang_String_ == null)
				cb_setStartToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStartToken_Ljava_lang_String_);
			return cb_setStartToken_Ljava_lang_String_;
		}

		static void n_SetStartToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartToken = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStartToken;
		static IntPtr id_setStartToken_Ljava_lang_String_;
		public virtual unsafe string StartToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='getStartToken' and count(parameter)=0]"
			[Register ("getStartToken", "()Ljava/lang/String;", "GetGetStartTokenHandler")]
			get {
				if (id_getStartToken == IntPtr.Zero)
					id_getStartToken = JNIEnv.GetMethodID (class_ref, "getStartToken", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStartToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='setStartToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStartToken", "(Ljava/lang/String;)V", "GetSetStartToken_Ljava_lang_String_Handler")]
			set {
				if (id_setStartToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setStartToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStartToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStartToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartToken", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest p0 = (global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest)global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.ICloudDriveRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_CloudDriveRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.CloudDriveRequest']]"
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
			global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.PaginatedCloudDriveRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object another = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_another, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (another);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='Java.Lang.Object']]"
		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public abstract global::System.Int32 CompareTo (global::Java.Lang.Object another);

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/PaginatedCloudDriveRequest", DoNotGenerateAcw=true)]
	internal partial class PaginatedCloudDriveRequestInvoker : PaginatedCloudDriveRequest {

		public PaginatedCloudDriveRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaginatedCloudDriveRequestInvoker); }
		}

		static IntPtr id_compareTo_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='PaginatedCloudDriveRequest']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='Java.Lang.Object']]"
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
