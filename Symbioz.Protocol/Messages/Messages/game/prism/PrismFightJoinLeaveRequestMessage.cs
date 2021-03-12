


















// Generated on 06/04/2015 18:45:11
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class PrismFightJoinLeaveRequestMessage : Message
{

public const ushort Id = 5843;
public override ushort MessageId
{
    get { return Id; }
}

public ushort subAreaId;
        public bool join;
        

public PrismFightJoinLeaveRequestMessage()
{
}

public PrismFightJoinLeaveRequestMessage(ushort subAreaId, bool join)
        {
            this.subAreaId = subAreaId;
            this.join = join;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(subAreaId);
            writer.WriteBoolean(join);
            

}

public override void Deserialize(ICustomDataInput reader)
{

subAreaId = reader.ReadVarUhShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            join = reader.ReadBoolean();
            

}


}


}