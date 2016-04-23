using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageSummary']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/UsageSummary", DoNotGenerateAcw=true)]
	public partial class UsageSummary : global::Java.Lang.Object, global::Java.Lang.IComparable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/UsageSummary", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UsageSummary); }
		}

		protected UsageSummary (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageSummary']/constructor[@name='UsageSummary' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UsageSummary ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UsageSummary)) {
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

		static Delegate cb_getBillable;
#pragma warning disable 0169
		static Delegate GetGetBillableHandler ()
		{
			if (cb_getBillable == null)
				cb_getBillable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBillable);
			return cb_getBillable;
		}

		static IntPtr n_GetBillable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.UsageSummary __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Billable);
		}
#pragma warning restore 0169

		static Delegate cb_setBillable_Lcom_amazon_clouddrive_model_UsageDetail_;
#pragma warning disable 0169
		static Delegate GetSetBillable_Lcom_amazon_clouddrive_model_UsageDetail_Handler ()
		{
			if (cb_setBillable_Lcom_amazon_clouddrive_model_UsageDetail_ == null)
				cb_setBillable_Lcom_amazon_clouddrive_model_UsageDetail_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBillable_Lcom_amazon_clouddrive_model_UsageDetail_);
			return cb_setBillable_Lcom_amazon_clouddrive_model_UsageDetail_;
		}

		static void n_SetBillable_Lcom_amazon_clouddrive_model_UsageDetail_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UsageSummary __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UsageDetail p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Billable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBillable;
		static IntPtr id_setBillable_Lcom_amazon_clouddrive_model_UsageDetail_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UsageDetail Billable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageSummary']/method[@name='getBillable' and count(parameter)=0]"
			[Register ("getBillable", "()Lcom/amazon/clouddrive/model/UsageDetail;", "GetGetBillableHandler")]
			get {
				if (id_getBillable == IntPtr.Zero)
					id_getBillable = JNIEnv.GetMethodID (class_ref, "getBillable", "()Lcom/amazon/clouddrive/model/UsageDetail;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (JNIEnv.CallObjectMethod  (Handle, id_getBillable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBillable", "()Lcom/amazon/clouddrive/model/UsageDetail;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageSummary']/method[@name='setBillable' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.UsageDetail']]"
			[Register ("setBillable", "(Lcom/amazon/clouddrive/model/UsageDetail;)V", "GetSetBillable_Lcom_amazon_clouddrive_model_UsageDetail_Handler")]
			set {
				if (id_setBillable_Lcom_amazon_clouddrive_model_UsageDetail_ == IntPtr.Zero)
					id_setBillable_Lcom_amazon_clouddrive_model_UsageDetail_ = JNIEnv.GetMethodID (class_ref, "setBillable", "(Lcom/amazon/clouddrive/model/UsageDetail;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBillable_Lcom_amazon_clouddrive_model_UsageDetail_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBillable", "(Lcom/amazon/clouddrive/model/UsageDetail;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal;
#pragma warning disable 0169
		static Delegate GetGetTotalHandler ()
		{
			if (cb_getTotal == null)
				cb_getTotal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTotal);
			return cb_getTotal;
		}

		static IntPtr n_GetTotal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.UsageSummary __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Total);
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_Lcom_amazon_clouddrive_model_UsageDetail_;
#pragma warning disable 0169
		static Delegate GetSetTotal_Lcom_amazon_clouddrive_model_UsageDetail_Handler ()
		{
			if (cb_setTotal_Lcom_amazon_clouddrive_model_UsageDetail_ == null)
				cb_setTotal_Lcom_amazon_clouddrive_model_UsageDetail_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTotal_Lcom_amazon_clouddrive_model_UsageDetail_);
			return cb_setTotal_Lcom_amazon_clouddrive_model_UsageDetail_;
		}

		static void n_SetTotal_Lcom_amazon_clouddrive_model_UsageDetail_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UsageSummary __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UsageDetail p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Total = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTotal;
		static IntPtr id_setTotal_Lcom_amazon_clouddrive_model_UsageDetail_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Model.UsageDetail Total {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageSummary']/method[@name='getTotal' and count(parameter)=0]"
			[Register ("getTotal", "()Lcom/amazon/clouddrive/model/UsageDetail;", "GetGetTotalHandler")]
			get {
				if (id_getTotal == IntPtr.Zero)
					id_getTotal = JNIEnv.GetMethodID (class_ref, "getTotal", "()Lcom/amazon/clouddrive/model/UsageDetail;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (JNIEnv.CallObjectMethod  (Handle, id_getTotal), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotal", "()Lcom/amazon/clouddrive/model/UsageDetail;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageSummary']/method[@name='setTotal' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.UsageDetail']]"
			[Register ("setTotal", "(Lcom/amazon/clouddrive/model/UsageDetail;)V", "GetSetTotal_Lcom_amazon_clouddrive_model_UsageDetail_Handler")]
			set {
				if (id_setTotal_Lcom_amazon_clouddrive_model_UsageDetail_ == IntPtr.Zero)
					id_setTotal_Lcom_amazon_clouddrive_model_UsageDetail_ = JNIEnv.GetMethodID (class_ref, "setTotal", "(Lcom/amazon/clouddrive/model/UsageDetail;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTotal_Lcom_amazon_clouddrive_model_UsageDetail_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotal", "(Lcom/amazon/clouddrive/model/UsageDetail;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_UsageSummary_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_UsageSummary_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_UsageSummary_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_UsageSummary_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_UsageSummary_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_UsageSummary_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_UsageSummary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UsageSummary __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UsageSummary p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageSummary> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_UsageSummary_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageSummary']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.UsageSummary']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/UsageSummary;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_UsageSummary_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.UsageSummary p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_UsageSummary_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_UsageSummary_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/UsageSummary;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_UsageSummary_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/UsageSummary;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
