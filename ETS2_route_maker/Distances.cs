using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ETS2_route_maker
{
    [HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("Distances"), XmlSchemaProvider("GetTypedDataSetSchema")]
    [System.Serializable]
    public class Distances : DataSet
    {
        private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), System.Diagnostics.DebuggerNonUserCode]
        public override SchemaSerializationMode SchemaSerializationMode
        {
            get
            {
                return this._schemaSerializationMode;
            }
            set
            {
                this._schemaSerializationMode = value;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), System.Diagnostics.DebuggerNonUserCode]
        public new DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), System.Diagnostics.DebuggerNonUserCode]
        public new DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        public Distances()
        {
            base.BeginInit();
            this.InitClass();
            CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += value;
            base.Relations.CollectionChanged += value;
            base.EndInit();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        protected Distances(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context, false)
        {
            if (base.IsBinarySerialized(info, context))
            {
                this.InitVars(false);
                CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += value;
                this.Relations.CollectionChanged += value;
            }
            else
            {
                string s = (string)info.GetValue("XmlSchema", typeof(string));
                if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
                {
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(s)));
                    base.DataSetName = dataSet.DataSetName;
                    base.Prefix = dataSet.Prefix;
                    base.Namespace = dataSet.Namespace;
                    base.Locale = dataSet.Locale;
                    base.CaseSensitive = dataSet.CaseSensitive;
                    base.EnforceConstraints = dataSet.EnforceConstraints;
                    base.Merge(dataSet, false, MissingSchemaAction.Add);
                    this.InitVars();
                }
                else
                {
                    base.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(s)));
                }
                base.GetSerializationData(info, context);
                CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.SchemaChanged);
                base.Tables.CollectionChanged += value2;
                this.Relations.CollectionChanged += value2;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        protected override void InitializeDerivedDataSet()
        {
            base.BeginInit();
            this.InitClass();
            base.EndInit();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        public override DataSet Clone()
        {
            Distances distances = (Distances)base.Clone();
            distances.InitVars();
            distances.SchemaSerializationMode = this.SchemaSerializationMode;
            return distances;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        protected override bool ShouldSerializeTables()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        protected override bool ShouldSerializeRelations()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        protected override void ReadXmlSerializable(XmlReader reader)
        {
            if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
            {
                this.Reset();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(reader);
                base.DataSetName = dataSet.DataSetName;
                base.Prefix = dataSet.Prefix;
                base.Namespace = dataSet.Namespace;
                base.Locale = dataSet.Locale;
                base.CaseSensitive = dataSet.CaseSensitive;
                base.EnforceConstraints = dataSet.EnforceConstraints;
                base.Merge(dataSet, false, MissingSchemaAction.Add);
                this.InitVars();
            }
            else
            {
                base.ReadXml(reader);
                this.InitVars();
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        protected override XmlSchema GetSchemaSerializable()
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
            memoryStream.Position = 0L;
            return XmlSchema.Read(new XmlTextReader(memoryStream), null);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        internal void InitVars()
        {
            this.InitVars(true);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        internal void InitVars(bool initTable)
        {
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        private void InitClass()
        {
            base.DataSetName = "Distances";
            base.Prefix = "";
            base.Namespace = "http://tempuri.org/Distances.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        private void SchemaChanged(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)
            {
                this.InitVars();
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), System.Diagnostics.DebuggerNonUserCode]
        public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
        {
            Distances distances = new Distances();
            XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
            XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
            XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
            xmlSchemaAny.Namespace = distances.Namespace;
            xmlSchemaSequence.Items.Add(xmlSchemaAny);
            xmlSchemaComplexType.Particle = xmlSchemaSequence;
            XmlSchema schemaSerializable = distances.GetSchemaSerializable();
            XmlSchemaComplexType result;
            if (xs.Contains(schemaSerializable.TargetNamespace))
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                System.IO.MemoryStream memoryStream2 = new System.IO.MemoryStream();
                try
                {
                    schemaSerializable.Write(memoryStream);
                    System.Collections.IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
                        memoryStream2.SetLength(0L);
                        xmlSchema.Write(memoryStream2);
                        if (memoryStream.Length == memoryStream2.Length)
                        {
                            memoryStream.Position = 0L;
                            memoryStream2.Position = 0L;
                            while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
                            {
                            }
                            if (memoryStream.Position == memoryStream.Length)
                            {
                                result = xmlSchemaComplexType;
                                return result;
                            }
                        }
                    }
                }
                finally
                {
                    if (memoryStream != null)
                    {
                        memoryStream.Close();
                    }
                    if (memoryStream2 != null)
                    {
                        memoryStream2.Close();
                    }
                }
            }
            xs.Add(schemaSerializable);
            result = xmlSchemaComplexType;
            return result;
        }
    }
}
