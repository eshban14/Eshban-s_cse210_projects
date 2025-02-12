public class Comments{
   private string commenterName;
   private string commentText;

   public Comments(string commenterName, string commentText)
   {
      this.commenterName = commenterName;  
        this.commentText = commentText; 
   }

   public string GetCommenterName()
   {
      return commenterName;
   }

   public string GetCommentText()
   {
      return commentText;
   }

}