namespace DeploymentFramework.HelloWorld {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DeploymentFramework.HelloWorld.POSchema", typeof(global::DeploymentFramework.HelloWorld.POSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DeploymentFramework.HelloWorld.InvoiceSchema", typeof(global::DeploymentFramework.HelloWorld.InvoiceSchema))]
    public sealed class POToInvoice : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://HelloWorld.POSchema"" xmlns:ns0=""http://HelloWorld.InvoiceSchema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PO"" />
  </xsl:template>
  <xsl:template match=""/s0:PO"">
    <ns0:Invoice>
      <Number>
        <xsl:value-of select=""PO_Number/text()"" />
      </Number>
      <TotalPrice>
        <xsl:value-of select=""Total/text()"" />
      </TotalPrice>
    </ns0:Invoice>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DeploymentFramework.HelloWorld.POSchema";
        
        private const global::DeploymentFramework.HelloWorld.POSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DeploymentFramework.HelloWorld.InvoiceSchema";
        
        private const global::DeploymentFramework.HelloWorld.InvoiceSchema _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"DeploymentFramework.HelloWorld.POSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DeploymentFramework.HelloWorld.InvoiceSchema";
                return _TrgSchemas;
            }
        }
    }
}
