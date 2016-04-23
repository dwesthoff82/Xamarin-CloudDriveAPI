using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageDetail']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/model/UsageDetail", DoNotGenerateAcw=true)]
	public partial class UsageDetail : global::Java.Lang.Object, global::Java.Lang.IComparable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/model/UsageDetail", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UsageDetail); }
		}

		protected UsageDetail (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageDetail']/constructor[@name='UsageDetail' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UsageDetail ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UsageDetail)) {
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

		static Delegate cb_getBytes;
#pragma warning disable 0169
		static Delegate GetGetBytesHandler ()
		{
			if (cb_getBytes == null)
				cb_getBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBytes);
			return cb_getBytes;
		}

		static long n_GetBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Model.UsageDetail __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bytes;
		}
#pragma warning restore 0169

		static Delegate cb_setBytes_J;
#pragma warning disable 0169
		static Delegate GetSetBytes_JHandler ()
		{
			if (cb_setBytes_J == null)
				cb_setBytes_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBytes_J);
			return cb_setBytes_J;
		}

		static void n_SetBytes_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Amazon.Clouddrive.Model.UsageDetail __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Bytes = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBytes;
		static IntPtr id_setBytes_J;
		public virtual unsafe long Bytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageDetail']/method[@name='getBytes' and count(parameter)=0]"
			[Register ("getBytes", "()J", "GetGetBytesHandler")]
			get {
				if (id_getBytes == IntPtr.Zero)
					id_getBytes = JNIEnv.GetMethodID (class_ref, "getBytes", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getBytes);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBytes", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageDetail']/method[@name='setBytes' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBytes", "(J)V", "GetSetBytes_JHandler")]
			set {
				if (id_setBytes_J == IntPtr.Zero)
					id_setBytes_J = JNIEnv.GetMethodID (class_ref, "setBytes", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBytes_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBytes", "(J)V"), __args);
				} finally {
				}
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
			global::Com.Amazon.Clouddrive.Model.UsageDetail __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Model.UsageDetail __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Count = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		static IntPtr id_setCount_J;
		public virtual unsafe long Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageDetail']/method[@name='getCount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageDetail']/method[@name='setCount' and count(parameter)=1 and parameter[1][@type='long']]"
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

		static Delegate cb_compareTo_Lcom_amazon_clouddrive_model_UsageDetail_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_amazon_clouddrive_model_UsageDetail_Handler ()
		{
			if (cb_compareTo_Lcom_amazon_clouddrive_model_UsageDetail_ == null)
				cb_compareTo_Lcom_amazon_clouddrive_model_UsageDetail_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_amazon_clouddrive_model_UsageDetail_);
			return cb_compareTo_Lcom_amazon_clouddrive_model_UsageDetail_;
		}

		static int n_CompareTo_Lcom_amazon_clouddrive_model_UsageDetail_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Model.UsageDetail __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Model.UsageDetail p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Model.UsageDetail> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_amazon_clouddrive_model_UsageDetail_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.model']/class[@name='UsageDetail']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.model.UsageDetail']]"
		[Register ("compareTo", "(Lcom/amazon/clouddrive/model/UsageDetail;)I", "GetCompareTo_Lcom_amazon_clouddrive_model_UsageDetail_Handler")]
		public virtual unsafe int CompareTo (global::Com.Amazon.Clouddrive.Model.UsageDetail p0)
		{
			if (id_compareTo_Lcom_amazon_clouddrive_model_UsageDetail_ == IntPtr.Zero)
				id_compareTo_Lcom_amazon_clouddrive_model_UsageDetail_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/amazon/clouddrive/model/UsageDetail;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_amazon_clouddrive_model_UsageDetail_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/amazon/clouddrive/model/UsageDetail;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
