import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import{ModalDismissReasons  ,NgbModal} from '@ng-bootstrap/ng-bootstrap';

export class Friend{
  constructor(
    public Id:Number,
    public f_name:string,
    public m_name:string,
    public l_name:string,
    public address:string,
    public birthDate:string,
    public score:string,
    public dep_id:string
  ){

  }
}

@Component({
  selector: 'app-friend',
  templateUrl: './friend.component.html',
  styleUrls: ['./friend.component.css']
})
export class FriendComponent implements OnInit {
  friends:Friend[];
  closeResult:string;
  

  constructor(
    private HttpClient:HttpClient,
    private modalService:NgbModal
  ) { }

  ngOnInit(): void {
    this.getFriends();
  }
  getFriends(){
    this.HttpClient.get<any>('https://localhost:44336/api/Student/').subscribe(
      response =>{
        console.log(response);
        this.friends=response;
      }
    );
  }

open(content){
  this.modalService.open(content,{ariaLabelledBy:'modal-basic-title'}).result.then((result)=>{this.closeResult=`Close with:${result}`;},(reason)=>{this.closeResult=`Dismissed ${this.getDismissReason(reason)}`;})
}

private getDismissReason(reason:any):string{
  if(reason ===ModalDismissReasons.ESC){
    return 'by pressing ESC';
  }else if(reason ===ModalDismissReasons.BACKDROP_CLICK){
    return 'by clicking on a backdrop';
  }else {
    return `with:${reason}`;
  }
}

}
