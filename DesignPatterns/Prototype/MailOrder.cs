namespace Prototype
{
    public class MailOrder : Prototype
    {
        public string SenderName { get; set; }
        public string RecipientName { get; set; }
        public bool IsDelivery { get; set; }
        public string MailContent { get; set; }
        public MailInfo Info { get; set; }

        public MailOrder(string senderName, string recipientName,
            bool isDelivery, string content, MailInfo info)
        {
            SenderName = senderName;
            RecipientName = recipientName;
            IsDelivery = isDelivery;
            MailContent = content;
            Info = info;
        }


        public override void Debug()
        {
            Console.WriteLine("************ Prototype Mail Order ************");
            Console.WriteLine($"Id:{Info.Id} | Sender name: {SenderName} | Recipient name: {RecipientName} | Delivered: {IsDelivery}");
            Console.WriteLine($"Mail content: {MailContent}");
        }

        public override Prototype ShallowCopy()
            => (Prototype)MemberwiseClone();

        public override Prototype DeepCopy()
        {
            MailOrder clonedMailOrder = (MailOrder)MemberwiseClone();
            clonedMailOrder.Info = new MailInfo(Info.Id);

            return clonedMailOrder;
        }





    }
}
