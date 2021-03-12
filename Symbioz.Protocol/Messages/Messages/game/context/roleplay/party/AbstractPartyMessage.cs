


















// Generated on 06/04/2015 18:44:33
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class AbstractPartyMessage : Message
{

public const ushort Id = 6274;
public override ushort MessageId
{
    get { return Id; }
}

public uint partyId;
        

public AbstractPartyMessage()
{
}

public AbstractPartyMessage(uint partyId)
        {
            this.partyId = partyId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(partyId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

partyId = reader.ReadVarUhInt();
            if (partyId < 0)
                throw new Exception("Forbidden value on partyId = " + partyId + ", it doesn't respect the following condition : partyId < 0");
            

}


}


}