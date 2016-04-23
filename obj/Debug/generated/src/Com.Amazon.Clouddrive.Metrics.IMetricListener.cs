using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Metrics {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.clouddrive.metrics']/interface[@name='MetricListener']"
	[Register ("com/amazon/clouddrive/metrics/MetricListener", "", "Com.Amazon.Clouddrive.Metrics.IMetricListenerInvoker")]
	public partial interface IMetricListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.metrics']/interface[@name='MetricListener']/method[@name='onMetricEvent' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.metrics.MetricEvent']]"
		[Register ("onMetricEvent", "(Lcom/amazon/clouddrive/metrics/MetricEvent;)V", "GetOnMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_Handler:Com.Amazon.Clouddrive.Metrics.IMetricListenerInvoker, CloudDriveAPI")]
		void OnMetricEvent (global::Com.Amazon.Clouddrive.Metrics.MetricEvent p0);

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/metrics/MetricListener", DoNotGenerateAcw=true)]
	internal class IMetricListenerInvoker : global::Java.Lang.Object, IMetricListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/clouddrive/metrics/MetricListener");
		IntPtr class_ref;

		public static IMetricListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMetricListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.clouddrive.metrics.MetricListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMetricListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMetricListenerInvoker); }
		}

		static Delegate cb_onMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_;
#pragma warning disable 0169
		static Delegate GetOnMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_Handler ()
		{
			if (cb_onMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_ == null)
				cb_onMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_);
			return cb_onMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_;
		}

		static void n_OnMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Metrics.IMetricListener __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Metrics.IMetricListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Metrics.MetricEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Metrics.MetricEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMetricEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_;
		public unsafe void OnMetricEvent (global::Com.Amazon.Clouddrive.Metrics.MetricEvent p0)
		{
			if (id_onMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_ == IntPtr.Zero)
				id_onMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_ = JNIEnv.GetMethodID (class_ref, "onMetricEvent", "(Lcom/amazon/clouddrive/metrics/MetricEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onMetricEvent_Lcom_amazon_clouddrive_metrics_MetricEvent_, __args);
		}

	}

	public partial class MetricEventArgs : global::System.EventArgs {

		public MetricEventArgs (global::Com.Amazon.Clouddrive.Metrics.MetricEvent p0)
		{
			this.p0 = p0;
		}

		global::Com.Amazon.Clouddrive.Metrics.MetricEvent p0;
		public global::Com.Amazon.Clouddrive.Metrics.MetricEvent P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/amazon/clouddrive/metrics/MetricListenerImplementor")]
	internal sealed partial class IMetricListenerImplementor : global::Java.Lang.Object, IMetricListener {

		object sender;

		public IMetricListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/amazon/clouddrive/metrics/MetricListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MetricEventArgs> Handler;
#pragma warning restore 0649

		public void OnMetricEvent (global::Com.Amazon.Clouddrive.Metrics.MetricEvent p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MetricEventArgs (p0));
		}

		internal static bool __IsEmpty (IMetricListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
