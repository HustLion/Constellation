﻿namespace Constellation.CoreNodes
{
    public class Exit : INode, IReceiver, IMirrorNode
    {
        private ISender sender;
        private Parameter attribute; // attributes are setted in the editor.
        public const string NAME = "Exit"; //Setting the node name (need to be a const to be used in the factory without the node instantiated)

        public void Setup(INodeParameters _node)
        {
            var wordValue = new Ray();
            _node.AddInput(this, false, "Any", "Output the entry received"); // setting a cold input
            attribute = _node.AddAttribute(wordValue.Set("Var"), Parameter.AttributeType.Word, "The default word");// setting an attribute (Used only for the editor)
        }

        //return the node name (used in the factory).
        public string NodeName()
        {
            return NAME;
        }

        //return the node namespace (used for the factory)
        public string NodeNamespace()
        {
            return NameSpace.NAME;
        }

        //Receive from inputs.
        public void Receive(Ray _value, Input _input)
        {
           
        }
    }
}