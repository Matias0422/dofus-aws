


















// Generated on 06/04/2015 18:45:14
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class TitleGainedMessage : Message
{

public const ushort Id = 6364;
public override ushort MessageId
{
    get { return Id; }
}

public ushort titleId;
        

public TitleGainedMessage()
{
}

public TitleGainedMessage(ushort titleId)
        {
            this.titleId = titleId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(titleId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

titleId = reader.ReadVarUhShort();
            if (titleId < 0)
                throw new Exception("Forbidden value on titleId = " + titleId + ", it doesn't respect the following condition : titleId < 0");
            

}


}


}