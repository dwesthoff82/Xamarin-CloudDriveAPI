using System;
using System.Collections;
using System.Collections.Generic;

namespace Com.Amazon.Clouddrive.Model {

	public partial class AddChildToParentRequest
	{
		public int CompareTo(Java.Lang.Object obj){
		
		
		
			return this.CompareTo ((ICloudDriveRequest)obj);
		}

	}

	public partial class AddNodePropertyRequest{


		public int CompareTo(Java.Lang.Object obj){

			return this.CompareTo ((ICloudDriveRequest)obj);
		}

	}

	public partial class AddNodePropertyResponse{

		public int CompareTo(Java.Lang.Object obj){
			
			return this.CompareTo ((ICloudDriveResponse)obj);
		}

	}

	public partial class ContentProperties{

		public int CompareTo(Java.Lang.Object obj){
			
			return this.CompareTo ((ContentProperties)obj);
		}

	}

	public partial class DeleteNodePropertyRequest{

		public int CompareTo(Java.Lang.Object obj){

			return this.CompareTo ((ICloudDriveRequest)obj);
		}
			
	}

	public partial class DocumentProperties{

		public int CompareTo(Java.Lang.Object obj){
				
			return this.CompareTo ((DocumentProperties)obj);
		}

	}

	public partial class DownloadFileRequest{


		public int CompareTo(Java.Lang.Object obj){

		
			return this.CompareTo ((ICloudDriveRequest)obj);
		}

	}

	public partial class EditableNode{


		public int CompareTo(Java.Lang.Object obj){
		
		
			return this.CompareTo ((EditableNode)obj);
		}

	}

	public partial class EditableNodeRequest{

		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveRequest)obj);
		}

	}

	public partial class GetAccountEndpointRequest{

		public int CompareTo(Java.Lang.Object obj){
			

			return this.CompareTo ((ICloudDriveRequest)obj);
		}

	}

	public partial class GetAccountEndpointResponse{

		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveResponse)obj);
		}



	}

	public partial class GetAccountInfoRequest{

		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveRequest)obj);
		}

	}

	public partial class GetAccountInfoResponse{

		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveResponse)obj);
		}

	}

	public partial class GetAccountQuotaRequest{


		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveRequest)obj);
		}
	}

	public partial class GetAccountQuotaResponse{

		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveResponse)obj);
		}
		
	}

	public partial class GetAccountUsageRequest{

		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveRequest)obj);
		}

	}

	public partial class GetAccountUsageResponse{


		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveResponse)obj);
		}

	}

	public partial class GetChangesRequest{

		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveRequest)obj);
		}

	}

	public partial class GetChangesResponse{

		public IList Nodes{ 
			get{
			
				return (IList)this._getNodes ();
			} 
			set{ 
				
				this.SetNodes (value as IList<Node>);
			
			}
		}

		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveResponse)obj);
		}

	}

	public partial class GetNodePropertyRequest{


		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveRequest)obj);
		}

	}

	public partial class GetNodePropertyResponse{


		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveResponse)obj);
		}
	}

	public partial class GetNodeRequest{

		public int CompareTo(Java.Lang.Object obj){


			return 0;
		}


	}

	public partial class ImageProperties{

		public int CompareTo(Java.Lang.Object obj){
			
			return 0;
		}
	}


	public partial class ListChildrenResponse{
		public IList Data{ get; set; }
		public override int CompareTo(Java.Lang.Object obj){


			return 0;
		}
			
	}

	public partial class ListChildrenRequest{

		public override int CompareTo(Java.Lang.Object obj){


			return 0;
		}

	}

	public partial class ListNodePropertiesRequest{

		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveRequest)obj);
		}


	}

	public partial class ListNodePropertiesResponse{


		public int CompareTo(Java.Lang.Object obj){


			return 0;
		}
	}

	public partial class ListNodesInTrashRequest{

		public override int CompareTo(Java.Lang.Object obj){


			return 0;
		}


	}

	public partial class ListNodesInTrashResponse{

		public IList Data{get;set;}

		public override int CompareTo(Java.Lang.Object obj){


			return 0;
		}
		

	}

	public partial class ListNodesRequest{

		public override int CompareTo(Java.Lang.Object obj){


			return 0;
		}


	}


	public partial class ListNodesResponse {

		public IList Data {
			
				get{

					return (IList)this._getData ();
				} 
				set{ 

					this.SetData (value as IList<Node>);

				}
			}

		public override int CompareTo(Java.Lang.Object obj){


			return 0;
		}


	}

	public partial class MembershipInfo{


		public int CompareTo(Java.Lang.Object obg){
		
		
			return this.CompareTo ((MembershipInfo)obg);
		}
	}

	public partial class MoveNodeToTrashRequest {


		public int CompareTo(Java.Lang.Object obj){


			return this.CompareTo ((ICloudDriveRequest)obj);
		}


	}

	public partial class RemoveChildFromParentRequest{


		public int CompareTo(Java.Lang.Object obj){
		
		
			return 0;
		}

	}

	public partial class RestoreNodeFromTrashRequest{


		public int CompareTo(Java.Lang.Object obj){


			return 0;
		}

	}

	public partial class UpdateNodeRequest{


		public int CompareTo(Java.Lang.Object obj){

		
			return 0;
		}

	}

	public partial class UsageDetail{

		public int CompareTo(Java.Lang.Object obj){



			return 0;
		}

	}


	public partial class UsageSummary{


		public int CompareTo(Java.Lang.Object obj){


			return 0;
		}
	}

	public partial class VideoProperties{


		public int CompareTo(Java.Lang.Object obj){


			return 0;
		}
	}



}

