using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Kara.Framework.Common.Helpers;

namespace Kara.Framework.Common.Enums
{
    public enum MimeTypes
    {
        [MimeTypeMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        AAB,

        [MimeTypeMetadata(Value = "audio/x-aac", IsBinary = true)]
        AAC,

        [MimeTypeMetadata(Value = "application/x-authorware-map", IsBinary = true)]
        AAM,

        [MimeTypeMetadata(Value = "application/x-authorware-seg", IsBinary = true)]
        AAS,

        [MimeTypeMetadata(Value = "application/x-abiword", IsBinary = true)]
        ABW,

        [MimeTypeMetadata(Value = "application/pkix-attr-cert", IsBinary = true)]
        AC,

        [MimeTypeMetadata(Value = "application/vnd.americandynamics.acc", IsBinary = true)]
        ACC,

        [MimeTypeMetadata(Value = "application/x-ace-compressed", IsBinary = true)]
        ACE,

        [MimeTypeMetadata(Value = "application/vnd.acucobol", IsBinary = true)]
        ACU,

        [MimeTypeMetadata(Value = "application/vnd.acucorp", IsBinary = true)]
        ACUTC,

        [MimeTypeMetadata(Value = "audio/adpcm", IsBinary = true)]
        ADP,

        [MimeTypeMetadata(Value = "application/vnd.audiograph", IsBinary = true)]
        AEP,

        [MimeTypeMetadata(Value = "application/x-font-type1", IsBinary = true)]
        AFM,

        [MimeTypeMetadata(Value = "application/vnd.ibm.modcap", IsBinary = true)]
        AFP,

        [MimeTypeMetadata(Value = "application/vnd.ahead.space", IsBinary = true)]
        AHEAD,

        [MimeTypeMetadata(Value = "application/postscript", IsBinary = true)]
        AI,

        [MimeTypeMetadata(Value = "audio/x-aiff", IsBinary = true)]
        AIF,

        [MimeTypeMetadata(Value = "audio/x-aiff", IsBinary = true)]
        AIFC,

        [MimeTypeMetadata(Value = "audio/x-aiff", IsBinary = true)]
        AIFF,

        [MimeTypeMetadata(Value = "application/vnd.adobe.air-application-installer-package+zip", IsBinary = true)]
        AIR,

        [MimeTypeMetadata(Value = "application/vnd.dvb.ait", IsBinary = true)]
        AIT,

        [MimeTypeMetadata(Value = "application/vnd.amiga.ami", IsBinary = true)]
        AMI,

        [MimeTypeMetadata(Value = "application/vnd.android.package-archive", IsBinary = true)]
        APK,

        [MimeTypeMetadata(Value = "text/cache-manifest", IsText = true)]
        APPCACHE,

        [MimeTypeMetadata(Value = "application/x-ms-application", IsBinary = true)]
        APPLICATION,

        [MimeTypeMetadata(Value = "application/vnd.lotus-approach", IsBinary = true)]
        APR,

        [MimeTypeMetadata(Value = "application/x-freearc", IsBinary = true)]
        ARC,

        [MimeTypeMetadata(Value = "text/plain", IsText = true)]
        ASC,

        [MimeTypeMetadata(Value = "video/x-ms-asf", IsBinary = true)]
        ASF,

        [MimeTypeMetadata(Value = "text/x-asm", IsText = true)]
        ASM,

        [MimeTypeMetadata(Value = "application/vnd.accpac.simply.aso", IsBinary = true)]
        ASO,

        [MimeTypeMetadata(Value = "video/x-ms-asf", IsBinary = true)]
        ASX,

        [MimeTypeMetadata(Value = "application/vnd.acucorp", IsBinary = true)]
        ATC,

        [MimeTypeMetadata(Value = "application/atom+xml", IsText = true)]
        ATOM,

        [MimeTypeMetadata(Value = "application/atomcat+xml", IsText = true)]
        ATOMCAT,

        [MimeTypeMetadata(Value = "application/atomsvc+xml", IsText = true)]
        ATOMSVC,

        [MimeTypeMetadata(Value = "application/vnd.antix.game-component", IsBinary = true)]
        ATX,

        [MimeTypeMetadata(Value = "audio/basic", IsBinary = true)]
        AU,

        [MimeTypeMetadata(Value = "video/x-msvideo", IsBinary = true)]
        AVI,

        [MimeTypeMetadata(Value = "application/applixware", IsBinary = true)]
        AW,

        [MimeTypeMetadata(Value = "application/vnd.airzip.filesecure.azf", IsBinary = true)]
        AZF,

        [MimeTypeMetadata(Value = "application/vnd.airzip.filesecure.azs", IsBinary = true)]
        AZS,

        [MimeTypeMetadata(Value = "application/vnd.amazon.ebook", IsBinary = true)]
        AZW,

        [MimeTypeMetadata(Value = "application/x-msdownload", IsBinary = true)]
        BAT,

        [MimeTypeMetadata(Value = "application/x-bcpio", IsBinary = true)]
        BCPIO,

        [MimeTypeMetadata(Value = "application/x-font-bdf", IsBinary = true)]
        BDF,

        [MimeTypeMetadata(Value = "application/vnd.syncml.dm+wbxml", IsText = true)]
        BDM,

        [MimeTypeMetadata(Value = "application/vnd.realvnc.bed", IsBinary = true)]
        BED,

        [MimeTypeMetadata(Value = "application/vnd.fujitsu.oasysprs", IsBinary = true)]
        BH2,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        BIN,

        [MimeTypeMetadata(Value = "application/x-blorb", IsBinary = true)]
        BLB,

        [MimeTypeMetadata(Value = "application/x-blorb", IsBinary = true)]
        BLORB,

        [MimeTypeMetadata(Value = "application/vnd.bmi", IsBinary = true)]
        BMI,

        [MimeTypeMetadata(Value = "image/bmp", IsBinary = true)]
        BMP,

        [MimeTypeMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        BOOK,

        [MimeTypeMetadata(Value = "application/vnd.previewsystems.box", IsBinary = true)]
        BOX,

        [MimeTypeMetadata(Value = "application/x-bzip2", IsBinary = true)]
        BOZ,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        BPK,

        [MimeTypeMetadata(Value = "image/prs.btif", IsBinary = true)]
        BTIF,

        [MimeTypeMetadata(Value = "application/x-bzip", IsBinary = true)]
        BZ,

        [MimeTypeMetadata(Value = "application/x-bzip2", IsBinary = true)]
        BZ2,

        [MimeTypeMetadata(Value = "text/x-c", IsText = true)]
        C,

        [MimeTypeMetadata(Value = "application/vnd.cluetrust.cartomobile-config", IsBinary = true)]
        C11AMC,

        [MimeTypeMetadata(Value = "application/vnd.cluetrust.cartomobile-config-pkg", IsBinary = true)]
        C11AMZ,

        [MimeTypeMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4D,

        [MimeTypeMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4F,

        [MimeTypeMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4G,

        [MimeTypeMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4P,

        [MimeTypeMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4U,

        [MimeTypeMetadata(Value = "application/vnd.ms-cab-compressed", IsBinary = true)]
        CAB,

        [MimeTypeMetadata(Value = "audio/x-caf", IsBinary = true)]
        CAF,

        [MimeTypeMetadata(Value = "application/vnd.tcpdump.pcap", IsBinary = true)]
        CAP,

        [MimeTypeMetadata(Value = "application/vnd.curl.car", IsBinary = true)]
        CAR,

        [MimeTypeMetadata(Value = "application/vnd.ms-pki.seccat", IsBinary = true)]
        CAT,

        [MimeTypeMetadata(Value = "application/x-cbr", IsBinary = true)]
        CB7,

        [MimeTypeMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBA,

        [MimeTypeMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBR,

        [MimeTypeMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBT,

        [MimeTypeMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBZ,

        [MimeTypeMetadata(Value = "text/x-c", IsText = true)]
        CC,

        [MimeTypeMetadata(Value = "application/x-director", IsBinary = true)]
        CCT,

        [MimeTypeMetadata(Value = "application/ccxml+xml", IsText = true)]
        CCXML,

        [MimeTypeMetadata(Value = "application/vnd.contact.cmsg", IsBinary = true)]
        CDBCMSG,

        [MimeTypeMetadata(Value = "application/x-netcdf", IsBinary = true)]
        CDF,

        [MimeTypeMetadata(Value = "application/vnd.mediastation.cdkey", IsBinary = true)]
        CDKEY,

        [MimeTypeMetadata(Value = "application/cdmi-capability", IsBinary = true)]
        CDMIA,

        [MimeTypeMetadata(Value = "application/cdmi-container", IsBinary = true)]
        CDMIC,

        [MimeTypeMetadata(Value = "application/cdmi-domain", IsBinary = true)]
        CDMID,

        [MimeTypeMetadata(Value = "application/cdmi-object", IsBinary = true)]
        CDMIO,

        [MimeTypeMetadata(Value = "application/cdmi-queue", IsBinary = true)]
        CDMIQ,

        [MimeTypeMetadata(Value = "chemical/x-cdx", IsBinary = true)]
        CDX,

        [MimeTypeMetadata(Value = "application/vnd.chemdraw+xml", IsText = true)]
        CDXML,

        [MimeTypeMetadata(Value = "application/vnd.cinderella", IsBinary = true)]
        CDY,

        [MimeTypeMetadata(Value = "application/pkix-cert", IsBinary = true)]
        CER,

        [MimeTypeMetadata(Value = "application/x-cfs-compressed", IsBinary = true)]
        CFS,

        [MimeTypeMetadata(Value = "image/cgm", IsBinary = true)]
        CGM,

        [MimeTypeMetadata(Value = "application/x-chat", IsBinary = true)]
        CHAT,

        [MimeTypeMetadata(Value = "application/vnd.ms-htmlhelp", IsBinary = true)]
        CHM,

        [MimeTypeMetadata(Value = "application/vnd.kde.kchart", IsBinary = true)]
        CHRT,

        [MimeTypeMetadata(Value = "chemical/x-cif", IsBinary = true)]
        CIF,

        [MimeTypeMetadata(Value = "application/vnd.anser-web-certificate-issue-initiation", IsBinary = true)]
        CII,

        [MimeTypeMetadata(Value = "application/vnd.ms-artgalry", IsBinary = true)]
        CIL,

        [MimeTypeMetadata(Value = "application/vnd.claymore", IsBinary = true)]
        CLA,

        [MimeTypeMetadata(Value = "application/java-vm", IsBinary = true)]
        CLASS,

        [MimeTypeMetadata(Value = "application/vnd.crick.clicker.keyboard", IsBinary = true)]
        CLKK,

        [MimeTypeMetadata(Value = "application/vnd.crick.clicker.palette", IsBinary = true)]
        CLKP,

        [MimeTypeMetadata(Value = "application/vnd.crick.clicker.template", IsBinary = true)]
        CLKT,

        [MimeTypeMetadata(Value = "application/vnd.crick.clicker.wordbank", IsBinary = true)]
        CLKW,

        [MimeTypeMetadata(Value = "application/vnd.crick.clicker", IsBinary = true)]
        CLKX,

        [MimeTypeMetadata(Value = "application/x-msclip", IsBinary = true)]
        CLP,

        [MimeTypeMetadata(Value = "application/vnd.cosmocaller", IsBinary = true)]
        CMC,

        [MimeTypeMetadata(Value = "chemical/x-cmdf", IsBinary = true)]
        CMDF,

        [MimeTypeMetadata(Value = "chemical/x-cml", IsBinary = true)]
        CML,

        [MimeTypeMetadata(Value = "application/vnd.yellowriver-custom-menu", IsBinary = true)]
        CMP,

        [MimeTypeMetadata(Value = "image/x-cmx", IsBinary = true)]
        CMX,

        [MimeTypeMetadata(Value = "application/vnd.rim.cod", IsBinary = true)]
        COD,

        [MimeTypeMetadata(Value = "application/x-msdownload", IsBinary = true)]
        COM,

        [MimeTypeMetadata(Value = "text/plain", IsText = true)]
        CONF,

        [MimeTypeMetadata(Value = "application/x-cpio", IsBinary = true)]
        CPIO,

        [MimeTypeMetadata(Value = "text/x-c", IsText = true)]
        CPP,

        [MimeTypeMetadata(Value = "application/mac-compactpro", IsBinary = true)]
        CPT,

        [MimeTypeMetadata(Value = "application/x-mscardfile", IsBinary = true)]
        CRD,

        [MimeTypeMetadata(Value = "application/pkix-crl", IsBinary = true)]
        CRL,

        [MimeTypeMetadata(Value = "application/x-x509-ca-cert", IsBinary = true)]
        CRT,

        [MimeTypeMetadata(Value = "application/vnd.rig.cryptonote", IsBinary = true)]
        CRYPTONOTE,

        [MimeTypeMetadata(Value = "application/x-csh", IsBinary = true)]
        CSH,

        [MimeTypeMetadata(Value = "chemical/x-csml", IsBinary = true)]
        CSML,

        [MimeTypeMetadata(Value = "application/vnd.commonspace", IsBinary = true)]
        CSP,

        [MimeTypeMetadata(Value = "text/css", IsText = true)]
        CSS,

        [MimeTypeMetadata(Value = "application/x-director", IsBinary = true)]
        CST,

        [MimeTypeMetadata(Value = "text/csv", IsText = true)]
        CSV,

        [MimeTypeMetadata(Value = "application/cu-seeme", IsBinary = true)]
        CU,

        [MimeTypeMetadata(Value = "text/vnd.curl", IsText = true)]
        CURL,

        [MimeTypeMetadata(Value = "application/prs.cww", IsBinary = true)]
        CWW,

        [MimeTypeMetadata(Value = "application/x-director", IsBinary = true)]
        CXT,

        [MimeTypeMetadata(Value = "text/x-c", IsText = true)]
        CXX,

        [MimeTypeMetadata(Value = "model/vnd.collada+xml", IsText = true)]
        DAE,

        [MimeTypeMetadata(Value = "application/vnd.mobius.daf", IsBinary = true)]
        DAF,

        [MimeTypeMetadata(Value = "application/vnd.dart", IsBinary = true)]
        DART,

        [MimeTypeMetadata(Value = "application/vnd.fdsn.seed", IsBinary = true)]
        DATALESS,

        [MimeTypeMetadata(Value = "application/davmount+xml", IsText = true)]
        DAVMOUNT,

        [MimeTypeMetadata(Value = "application/docbook+xml", IsText = true)]
        DBK,

        [MimeTypeMetadata(Value = "application/x-director", IsBinary = true)]
        DCR,

        [MimeTypeMetadata(Value = "text/vnd.curl.dcurl", IsText = true)]
        DCURL,

        [MimeTypeMetadata(Value = "application/vnd.oma.dd2+xml", IsText = true)]
        DD2,

        [MimeTypeMetadata(Value = "application/vnd.fujixerox.ddd", IsBinary = true)]
        DDD,

        [MimeTypeMetadata(Value = "application/x-debian-package", IsBinary = true)]
        DEB,

        [MimeTypeMetadata(Value = "text/plain", IsText = true)]
        DEF,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        DEPLOY,

        [MimeTypeMetadata(Value = "application/x-x509-ca-cert", IsBinary = true)]
        DER,

        [MimeTypeMetadata(Value = "application/vnd.dreamfactory", IsBinary = true)]
        DFAC,

        [MimeTypeMetadata(Value = "application/x-dgc-compressed", IsBinary = true)]
        DGC,

        [MimeTypeMetadata(Value = "text/x-c", IsText = true)]
        DIC,

        [MimeTypeMetadata(Value = "video/x-dv", IsBinary = true)]
        DIF,

        [MimeTypeMetadata(Value = "application/x-director", IsBinary = true)]
        DIR,

        [MimeTypeMetadata(Value = "application/vnd.mobius.dis", IsBinary = true)]
        DIS,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        DIST,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        DISTZ,

        [MimeTypeMetadata(Value = "image/vnd.djvu", IsBinary = true)]
        DJV,

        [MimeTypeMetadata(Value = "image/vnd.djvu", IsBinary = true)]
        DJVU,

        [MimeTypeMetadata(Value = "application/x-msdownload", IsBinary = true)]
        DLL,

        [MimeTypeMetadata(Value = "application/x-apple-diskimage", IsBinary = true)]
        DMG,

        [MimeTypeMetadata(Value = "application/vnd.tcpdump.pcap", IsBinary = true)]
        DMP,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        DMS,

        [MimeTypeMetadata(Value = "application/vnd.dna", IsBinary = true)]
        DNA,

        [MimeTypeMetadata(Value = "application/msword", IsBinary = true)]
        DOC,

        [MimeTypeMetadata(Value = "application/vnd.ms-word.document.macroenabled.12", IsBinary = true)]
        DOCM,

        [MimeTypeMetadata(Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.document", IsBinary = true)]
        DOCX,

        [MimeTypeMetadata(Value = "application/msword", IsBinary = true)]
        DOT,

        [MimeTypeMetadata(Value = "application/vnd.ms-word.template.macroenabled.12", IsBinary = true)]
        DOTM,

        [MimeTypeMetadata(Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.template", IsBinary = true)]
        DOTX,

        [MimeTypeMetadata(Value = "application/vnd.osgi.dp", IsBinary = true)]
        DP,

        [MimeTypeMetadata(Value = "application/vnd.dpgraph", IsBinary = true)]
        DPG,

        [MimeTypeMetadata(Value = "audio/vnd.dra", IsBinary = true)]
        DRA,

        [MimeTypeMetadata(Value = "text/prs.lines.tag", IsText = true)]
        DSC,

        [MimeTypeMetadata(Value = "application/dssc+der", IsBinary = true)]
        DSSC,

        [MimeTypeMetadata(Value = "application/x-dtbook+xml", IsText = true)]
        DTB,

        [MimeTypeMetadata(Value = "application/xml-dtd", IsBinary = true)]
        DTD,

        [MimeTypeMetadata(Value = "audio/vnd.dts", IsBinary = true)]
        DTS,

        [MimeTypeMetadata(Value = "audio/vnd.dts.hd", IsBinary = true)]
        DTSHD,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        DUMP,

        [MimeTypeMetadata(Value = "video/x-dv", IsBinary = true)]
        DV,

        [MimeTypeMetadata(Value = "video/vnd.dvb.file", IsBinary = true)]
        DVB,

        [MimeTypeMetadata(Value = "application/x-dvi", IsBinary = true)]
        DVI,

        [MimeTypeMetadata(Value = "model/vnd.dwf", IsBinary = true)]
        DWF,

        [MimeTypeMetadata(Value = "image/vnd.dwg", IsBinary = true)]
        DWG,

        [MimeTypeMetadata(Value = "image/vnd.dxf", IsBinary = true)]
        DXF,

        [MimeTypeMetadata(Value = "application/vnd.spotfire.dxp", IsBinary = true)]
        DXP,

        [MimeTypeMetadata(Value = "application/x-director", IsBinary = true)]
        DXR,

        [MimeTypeMetadata(Value = "audio/vnd.nuera.ecelp4800", IsBinary = true)]
        ECELP4800,

        [MimeTypeMetadata(Value = "audio/vnd.nuera.ecelp7470", IsBinary = true)]
        ECELP7470,

        [MimeTypeMetadata(Value = "audio/vnd.nuera.ecelp9600", IsBinary = true)]
        ECELP9600,

        [MimeTypeMetadata(Value = "application/ecmascript", IsBinary = true)]
        ECMA,

        [MimeTypeMetadata(Value = "application/vnd.novadigm.edm", IsBinary = true)]
        EDM,

        [MimeTypeMetadata(Value = "application/vnd.novadigm.edx", IsBinary = true)]
        EDX,

        [MimeTypeMetadata(Value = "application/vnd.picsel", IsBinary = true)]
        EFIF,

        [MimeTypeMetadata(Value = "application/vnd.pg.osasli", IsBinary = true)]
        EI6,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        ELC,

        [MimeTypeMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        EMF,

        [MimeTypeMetadata(Value = "message/rfc822", IsBinary = true)]
        EML,

        [MimeTypeMetadata(Value = "application/emma+xml", IsText = true)]
        EMMA,

        [MimeTypeMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        EMZ,

        [MimeTypeMetadata(Value = "audio/vnd.digital-winds", IsBinary = true)]
        EOL,

        [MimeTypeMetadata(Value = "application/vnd.ms-fontobject", IsBinary = true)]
        EOT,

        [MimeTypeMetadata(Value = "application/postscript", IsBinary = true)]
        EPS,

        [MimeTypeMetadata(Value = "application/epub+zip", IsBinary = true)]
        EPUB,

        [MimeTypeMetadata(Value = "application/vnd.eszigno3+xml", IsText = true)]
        ES3,

        [MimeTypeMetadata(Value = "application/vnd.osgi.subsystem", IsBinary = true)]
        ESA,

        [MimeTypeMetadata(Value = "application/vnd.epson.esf", IsBinary = true)]
        ESF,

        [MimeTypeMetadata(Value = "application/vnd.eszigno3+xml", IsText = true)]
        ET3,

        [MimeTypeMetadata(Value = "text/x-setext", IsText = true)]
        ETX,

        [MimeTypeMetadata(Value = "application/x-eva", IsBinary = true)]
        EVA,

        [MimeTypeMetadata(Value = "application/x-envoy", IsBinary = true)]
        EVY,

        [MimeTypeMetadata(Value = "application/x-msdownload", IsBinary = true)]
        EXE,

        [MimeTypeMetadata(Value = "application/exi", IsBinary = true)]
        EXI,

        [MimeTypeMetadata(Value = "application/vnd.novadigm.ext", IsBinary = true)]
        EXT,

        [MimeTypeMetadata(Value = "MIME type (lowercased)", IsBinary = true)]
        EXTENSIONS,

        [MimeTypeMetadata(Value = "application/andrew-inset", IsBinary = true)]
        EZ,

        [MimeTypeMetadata(Value = "application/vnd.ezpix-album", IsBinary = true)]
        EZ2,

        [MimeTypeMetadata(Value = "application/vnd.ezpix-package", IsBinary = true)]
        EZ3,

        [MimeTypeMetadata(Value = "text/x-fortran", IsText = true)]
        F,

        [MimeTypeMetadata(Value = "video/x-f4v", IsBinary = true)]
        F4V,

        [MimeTypeMetadata(Value = "text/x-fortran", IsText = true)]
        F77,

        [MimeTypeMetadata(Value = "text/x-fortran", IsText = true)]
        F90,

        [MimeTypeMetadata(Value = "image/vnd.fastbidsheet", IsBinary = true)]
        FBS,

        [MimeTypeMetadata(Value = "application/vnd.adobe.formscentral.fcdt", IsBinary = true)]
        FCDT,

        [MimeTypeMetadata(Value = "application/vnd.isac.fcs", IsBinary = true)]
        FCS,

        [MimeTypeMetadata(Value = "application/vnd.fdf", IsBinary = true)]
        FDF,

        [MimeTypeMetadata(Value = "application/vnd.denovo.fcselayout-link", IsBinary = true)]
        FE_LAUNCH,

        [MimeTypeMetadata(Value = "application/vnd.fujitsu.oasysgp", IsBinary = true)]
        FG5,

        [MimeTypeMetadata(Value = "application/x-director", IsBinary = true)]
        FGD,

        [MimeTypeMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH,

        [MimeTypeMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH4,

        [MimeTypeMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH5,

        [MimeTypeMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH7,

        [MimeTypeMetadata(Value = "image/x-freehand", IsBinary = true)]
        FHC,

        [MimeTypeMetadata(Value = "application/x-xfig", IsBinary = true)]
        FIG,

        [MimeTypeMetadata(Value = "audio/x-flac", IsBinary = true)]
        FLAC,

        [MimeTypeMetadata(Value = "video/x-fli", IsBinary = true)]
        FLI,

        [MimeTypeMetadata(Value = "application/vnd.micrografx.flo", IsBinary = true)]
        FLO,

        [MimeTypeMetadata(Value = "video/x-flv", IsBinary = true)]
        FLV,

        [MimeTypeMetadata(Value = "application/vnd.kde.kivio", IsBinary = true)]
        FLW,

        [MimeTypeMetadata(Value = "text/vnd.fmi.flexstor", IsText = true)]
        FLX,

        [MimeTypeMetadata(Value = "text/vnd.fly", IsText = true)]
        FLY,

        [MimeTypeMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        FM,

        [MimeTypeMetadata(Value = "application/vnd.frogans.fnc", IsBinary = true)]
        FNC,

        [MimeTypeMetadata(Value = "text/x-fortran", IsText = true)]
        FOR,

        [MimeTypeMetadata(Value = "image/vnd.fpx", IsBinary = true)]
        FPX,

        [MimeTypeMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        FRAME,

        [MimeTypeMetadata(Value = "application/vnd.fsc.weblaunch", IsBinary = true)]
        FSC,

        [MimeTypeMetadata(Value = "image/vnd.fst", IsBinary = true)]
        FST,

        [MimeTypeMetadata(Value = "application/vnd.fluxtime.clip", IsBinary = true)]
        FTC,

        [MimeTypeMetadata(Value = "application/vnd.anser-web-funds-transfer-initiation", IsBinary = true)]
        FTI,

        [MimeTypeMetadata(Value = "video/vnd.fvt", IsBinary = true)]
        FVT,

        [MimeTypeMetadata(Value = "application/vnd.adobe.fxp", IsBinary = true)]
        FXP,

        [MimeTypeMetadata(Value = "application/vnd.adobe.fxp", IsBinary = true)]
        FXPL,

        [MimeTypeMetadata(Value = "application/vnd.fuzzysheet", IsBinary = true)]
        FZS,

        [MimeTypeMetadata(Value = "application/vnd.geoplan", IsBinary = true)]
        G2W,

        [MimeTypeMetadata(Value = "image/g3fax", IsBinary = true)]
        G3,

        [MimeTypeMetadata(Value = "application/vnd.geospace", IsBinary = true)]
        G3W,

        [MimeTypeMetadata(Value = "application/vnd.groove-account", IsBinary = true)]
        GAC,

        [MimeTypeMetadata(Value = "application/x-tads", IsBinary = true)]
        GAM,

        [MimeTypeMetadata(Value = "application/rpki-ghostbusters", IsBinary = true)]
        GBR,

        [MimeTypeMetadata(Value = "application/x-gca-compressed", IsBinary = true)]
        GCA,

        [MimeTypeMetadata(Value = "model/vnd.gdl", IsBinary = true)]
        GDL,

        [MimeTypeMetadata(Value = "application/vnd.dynageo", IsBinary = true)]
        GEO,

        [MimeTypeMetadata(Value = "application/vnd.geometry-explorer", IsBinary = true)]
        GEX,

        [MimeTypeMetadata(Value = "application/vnd.geogebra.file", IsBinary = true)]
        GGB,

        [MimeTypeMetadata(Value = "application/vnd.geogebra.tool", IsBinary = true)]
        GGT,

        [MimeTypeMetadata(Value = "application/vnd.groove-help", IsBinary = true)]
        GHF,

        [MimeTypeMetadata(Value = "image/gif", IsBinary = true)]
        GIF,

        [MimeTypeMetadata(Value = "application/vnd.groove-identity-message", IsBinary = true)]
        GIM,

        [MimeTypeMetadata(Value = "application/gml+xml", IsText = true)]
        GML,

        [MimeTypeMetadata(Value = "application/vnd.gmx", IsBinary = true)]
        GMX,

        [MimeTypeMetadata(Value = "application/x-gnumeric", IsBinary = true)]
        GNUMERIC,

        [MimeTypeMetadata(Value = "application/vnd.flographit", IsBinary = true)]
        GPH,

        [MimeTypeMetadata(Value = "application/gpx+xml", IsText = true)]
        GPX,

        [MimeTypeMetadata(Value = "application/vnd.grafeq", IsBinary = true)]
        GQF,

        [MimeTypeMetadata(Value = "application/vnd.grafeq", IsBinary = true)]
        GQS,

        [MimeTypeMetadata(Value = "application/srgs", IsBinary = true)]
        GRAM,

        [MimeTypeMetadata(Value = "application/x-gramps-xml", IsText = true)]
        GRAMPS,

        [MimeTypeMetadata(Value = "application/vnd.geometry-explorer", IsBinary = true)]
        GRE,

        [MimeTypeMetadata(Value = "application/vnd.groove-injector", IsBinary = true)]
        GRV,

        [MimeTypeMetadata(Value = "application/srgs+xml", IsText = true)]
        GRXML,

        [MimeTypeMetadata(Value = "application/x-font-ghostscript", IsBinary = true)]
        GSF,

        [MimeTypeMetadata(Value = "application/x-gtar", IsBinary = true)]
        GTAR,

        [MimeTypeMetadata(Value = "application/vnd.groove-tool-message", IsBinary = true)]
        GTM,

        [MimeTypeMetadata(Value = "model/vnd.gtw", IsBinary = true)]
        GTW,

        [MimeTypeMetadata(Value = "text/vnd.graphviz", IsText = true)]
        GV,

        [MimeTypeMetadata(Value = "application/gxf", IsBinary = true)]
        GXF,

        [MimeTypeMetadata(Value = "application/vnd.geonext", IsBinary = true)]
        GXT,

        [MimeTypeMetadata(Value = "text/x-c", IsText = true)]
        H,

        [MimeTypeMetadata(Value = "video/h261", IsBinary = true)]
        H261,

        [MimeTypeMetadata(Value = "video/h263", IsBinary = true)]
        H263,

        [MimeTypeMetadata(Value = "video/h264", IsBinary = true)]
        H264,

        [MimeTypeMetadata(Value = "application/vnd.hal+xml", IsText = true)]
        HAL,

        [MimeTypeMetadata(Value = "application/vnd.hbci", IsBinary = true)]
        HBCI,

        [MimeTypeMetadata(Value = "application/x-hdf", IsBinary = true)]
        HDF,

        [MimeTypeMetadata(Value = "text/x-c", IsText = true)]
        HH,

        [MimeTypeMetadata(Value = "application/winhlp", IsBinary = true)]
        HLP,

        [MimeTypeMetadata(Value = "application/vnd.hp-hpgl", IsBinary = true)]
        HPGL,

        [MimeTypeMetadata(Value = "application/vnd.hp-hpid", IsBinary = true)]
        HPID,

        [MimeTypeMetadata(Value = "application/vnd.hp-hps", IsBinary = true)]
        HPS,

        [MimeTypeMetadata(Value = "application/mac-binhex40", IsBinary = true)]
        HQX,

        [MimeTypeMetadata(Value = "application/vnd.kenameaapp", IsBinary = true)]
        HTKE,

        [MimeTypeMetadata(Value = "text/html", IsText = true)]
        HTM,

        [MimeTypeMetadata(Value = "text/html", IsText = true)]
        HTML,

        [MimeTypeMetadata(Value = "application/vnd.yamaha.hv-dic", IsBinary = true)]
        HVD,

        [MimeTypeMetadata(Value = "application/vnd.yamaha.hv-voice", IsBinary = true)]
        HVP,

        [MimeTypeMetadata(Value = "application/vnd.yamaha.hv-script", IsBinary = true)]
        HVS,

        [MimeTypeMetadata(Value = "application/vnd.intergeo", IsBinary = true)]
        I2G,

        [MimeTypeMetadata(Value = "x-conference/x-cooltalk", IsBinary = true)]
        IC,

        [MimeTypeMetadata(Value = "application/vnd.iccprofile", IsBinary = true)]
        ICC,

        [MimeTypeMetadata(Value = "x-conference/x-cooltalk", IsBinary = true)]
        ICE,

        [MimeTypeMetadata(Value = "application/vnd.iccprofile", IsBinary = true)]
        ICM,

        [MimeTypeMetadata(Value = "image/x-icon", IsBinary = true)]
        ICO,

        [MimeTypeMetadata(Value = "text/calendar", IsText = true)]
        ICS,

        [MimeTypeMetadata(Value = "image/ief", IsBinary = true)]
        IEF,

        [MimeTypeMetadata(Value = "text/calendar", IsText = true)]
        IFB,

        [MimeTypeMetadata(Value = "application/vnd.shana.informed.formdata", IsBinary = true)]
        IFM,

        [MimeTypeMetadata(Value = "model/iges", IsBinary = true)]
        IGES,

        [MimeTypeMetadata(Value = "application/vnd.igloader", IsBinary = true)]
        IGL,

        [MimeTypeMetadata(Value = "application/vnd.insors.igm", IsBinary = true)]
        IGM,

        [MimeTypeMetadata(Value = "model/iges", IsBinary = true)]
        IGS,

        [MimeTypeMetadata(Value = "application/vnd.micrografx.igx", IsBinary = true)]
        IGX,

        [MimeTypeMetadata(Value = "application/vnd.shana.informed.interchange", IsBinary = true)]
        IIF,

        [MimeTypeMetadata(Value = "application/vnd.accpac.simply.imp", IsBinary = true)]
        IMP,

        [MimeTypeMetadata(Value = "application/vnd.ms-ims", IsBinary = true)]
        IMS,

        [MimeTypeMetadata(Value = "text/plain", IsText = true)]
        IN,

        [MimeTypeMetadata(Value = "application/inkml+xml", IsText = true)]
        INK,

        [MimeTypeMetadata(Value = "application/inkml+xml", IsText = true)]
        INKML,

        [MimeTypeMetadata(Value = "application/x-install-instructions", IsBinary = true)]
        INSTALL,

        [MimeTypeMetadata(Value = "application/vnd.astraea-software.iota", IsBinary = true)]
        IOTA,

        [MimeTypeMetadata(Value = "application/ipfix", IsBinary = true)]
        IPFIX,

        [MimeTypeMetadata(Value = "application/vnd.shana.informed.package", IsBinary = true)]
        IPK,

        [MimeTypeMetadata(Value = "application/vnd.ibm.rights-management", IsBinary = true)]
        IRM,

        [MimeTypeMetadata(Value = "application/vnd.irepository.package+xml", IsText = true)]
        IRP,

        [MimeTypeMetadata(Value = "application/x-iso9660-image", IsBinary = true)]
        ISO,

        [MimeTypeMetadata(Value = "application/vnd.shana.informed.formtemplate", IsBinary = true)]
        ITP,

        [MimeTypeMetadata(Value = "application/vnd.immervision-ivp", IsBinary = true)]
        IVP,

        [MimeTypeMetadata(Value = "application/vnd.immervision-ivu", IsBinary = true)]
        IVU,

        [MimeTypeMetadata(Value = "text/vnd.sun.j2me.app-descriptor", IsText = true)]
        JAD,

        [MimeTypeMetadata(Value = "application/vnd.jam", IsBinary = true)]
        JAM,

        [MimeTypeMetadata(Value = "application/java-archive", IsBinary = true)]
        JAR,

        [MimeTypeMetadata(Value = "text/x-java-source", IsText = true)]
        JAVA,

        [MimeTypeMetadata(Value = "application/vnd.jisp", IsBinary = true)]
        JISP,

        [MimeTypeMetadata(Value = "application/vnd.hp-jlyt", IsBinary = true)]
        JLT,

        [MimeTypeMetadata(Value = "application/x-java-jnlp-file", IsBinary = true)]
        JNLP,

        [MimeTypeMetadata(Value = "application/vnd.joost.joda-archive", IsBinary = true)]
        JODA,

        [MimeTypeMetadata(Value = "image/jp2", IsBinary = true)]
        JP2,

        [MimeTypeMetadata(Value = "image/jpeg", IsBinary = true)]
        JPE,

        [MimeTypeMetadata(Value = "image/jpeg", IsBinary = true)]
        JPEG,

        [MimeTypeMetadata(Value = "image/jpeg", IsBinary = true)]
        JPG,

        [MimeTypeMetadata(Value = "video/jpm", IsBinary = true)]
        JPGM,

        [MimeTypeMetadata(Value = "video/jpeg", IsBinary = true)]
        JPGV,

        [MimeTypeMetadata(Value = "video/jpm", IsBinary = true)]
        JPM,

        [MimeTypeMetadata(Value = "application/javascript", IsText = true)]
        JS,

        [MimeTypeMetadata(Value = "application/json", IsText = true)]
        JSON,

        [MimeTypeMetadata(Value = "application/jsonml+json", IsText = true)]
        JSONML,

        [MimeTypeMetadata(Value = "audio/midi", IsBinary = true)]
        KAR,

        [MimeTypeMetadata(Value = "application/vnd.kde.karbon", IsBinary = true)]
        KARBON,

        [MimeTypeMetadata(Value = "application/vnd.kde.kformula", IsBinary = true)]
        KFO,

        [MimeTypeMetadata(Value = "application/vnd.kidspiration", IsBinary = true)]
        KIA,

        [MimeTypeMetadata(Value = "application/vnd.google-earth.kml+xml", IsText = true)]
        KML,

        [MimeTypeMetadata(Value = "application/vnd.google-earth.kmz", IsBinary = true)]
        KMZ,

        [MimeTypeMetadata(Value = "application/vnd.kinar", IsBinary = true)]
        KNE,

        [MimeTypeMetadata(Value = "application/vnd.kinar", IsBinary = true)]
        KNP,

        [MimeTypeMetadata(Value = "application/vnd.kde.kontour", IsBinary = true)]
        KON,

        [MimeTypeMetadata(Value = "application/vnd.kde.kpresenter", IsBinary = true)]
        KPR,

        [MimeTypeMetadata(Value = "application/vnd.kde.kpresenter", IsBinary = true)]
        KPT,

        [MimeTypeMetadata(Value = "application/vnd.ds-keypoint", IsBinary = true)]
        KPXX,

        [MimeTypeMetadata(Value = "application/vnd.kde.kspread", IsBinary = true)]
        KSP,

        [MimeTypeMetadata(Value = "application/vnd.kahootz", IsBinary = true)]
        KTR,

        [MimeTypeMetadata(Value = "image/ktx", IsBinary = true)]
        KTX,

        [MimeTypeMetadata(Value = "application/vnd.kahootz", IsBinary = true)]
        KTZ,

        [MimeTypeMetadata(Value = "application/vnd.kde.kword", IsBinary = true)]
        KWD,

        [MimeTypeMetadata(Value = "application/vnd.kde.kword", IsBinary = true)]
        KWT,

        [MimeTypeMetadata(Value = "application/vnd.las.las+xml", IsText = true)]
        LASXML,

        [MimeTypeMetadata(Value = "application/x-latex", IsBinary = true)]
        LATEX,

        [MimeTypeMetadata(Value = "application/vnd.llamagraphics.life-balance.desktop", IsBinary = true)]
        LBD,

        [MimeTypeMetadata(Value = "application/vnd.llamagraphics.life-balance.exchange+xml", IsText = true)]
        LBE,

        [MimeTypeMetadata(Value = "application/vnd.hhe.lesson-player", IsBinary = true)]
        LES,

        [MimeTypeMetadata(Value = "application/x-lzh-compressed", IsBinary = true)]
        LHA,

        [MimeTypeMetadata(Value = "application/vnd.route66.link66+xml", IsText = true)]
        LINK66,

        [MimeTypeMetadata(Value = "text/plain", IsText = true)]
        LIST,

        [MimeTypeMetadata(Value = "application/vnd.ibm.modcap", IsBinary = true)]
        LIST3820,

        [MimeTypeMetadata(Value = "application/vnd.ibm.modcap", IsBinary = true)]
        LISTAFP,

        [MimeTypeMetadata(Value = "application/x-ms-shortcut", IsBinary = true)]
        LNK,

        [MimeTypeMetadata(Value = "text/plain", IsText = true)]
        LOG,

        [MimeTypeMetadata(Value = "application/lost+xml", IsText = true)]
        LOSTXML,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        LRF,

        [MimeTypeMetadata(Value = "application/vnd.ms-lrm", IsBinary = true)]
        LRM,

        [MimeTypeMetadata(Value = "application/vnd.frogans.ltf", IsBinary = true)]
        LTF,

        [MimeTypeMetadata(Value = "audio/vnd.lucent.voice", IsBinary = true)]
        LVP,

        [MimeTypeMetadata(Value = "application/vnd.lotus-wordpro", IsBinary = true)]
        LWP,

        [MimeTypeMetadata(Value = "application/x-lzh-compressed", IsBinary = true)]
        LZH,

        [MimeTypeMetadata(Value = "application/x-msmediaview", IsBinary = true)]
        M13,

        [MimeTypeMetadata(Value = "application/x-msmediaview", IsBinary = true)]
        M14,

        [MimeTypeMetadata(Value = "video/mpeg", IsBinary = true)]
        M1V,

        [MimeTypeMetadata(Value = "application/mp21", IsBinary = true)]
        M21,

        [MimeTypeMetadata(Value = "audio/mpeg", IsBinary = true)]
        M2A,

        [MimeTypeMetadata(Value = "video/mpeg", IsBinary = true)]
        M2V,

        [MimeTypeMetadata(Value = "audio/mpeg", IsBinary = true)]
        M3A,

        [MimeTypeMetadata(Value = "audio/x-mpegurl", IsBinary = true)]
        M3U,

        [MimeTypeMetadata(Value = "application/vnd.apple.mpegurl", IsBinary = true)]
        M3U8,

        [MimeTypeMetadata(Value = "audio/mp4a-latm", IsBinary = true)]
        M4A,

        [MimeTypeMetadata(Value = "audio/mp4a-latm", IsBinary = true)]
        M4B,

        [MimeTypeMetadata(Value = "audio/mp4a-latm", IsBinary = true)]
        M4P,

        [MimeTypeMetadata(Value = "video/vnd.mpegurl", IsBinary = true)]
        M4U,

        [MimeTypeMetadata(Value = "video/x-m4v", IsBinary = true)]
        M4V,

        [MimeTypeMetadata(Value = "application/mathematica", IsBinary = true)]
        MA,

        [MimeTypeMetadata(Value = "image/x-macpaint", IsBinary = true)]
        MAC,

        [MimeTypeMetadata(Value = "application/mads+xml", IsText = true)]
        MADS,

        [MimeTypeMetadata(Value = "application/vnd.ecowin.chart", IsBinary = true)]
        MAG,

        [MimeTypeMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        MAKER,

        [MimeTypeMetadata(Value = "application/x-troff-man", IsBinary = true)]
        MAN,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        MAR,

        [MimeTypeMetadata(Value = "application/mathml+xml", IsText = true)]
        MATHML,

        [MimeTypeMetadata(Value = "application/mathematica", IsBinary = true)]
        MB,

        [MimeTypeMetadata(Value = "application/vnd.mobius.mbk", IsBinary = true)]
        MBK,

        [MimeTypeMetadata(Value = "application/mbox", IsBinary = true)]
        MBOX,

        [MimeTypeMetadata(Value = "application/vnd.medcalcdata", IsBinary = true)]
        MC1,

        [MimeTypeMetadata(Value = "application/vnd.mcd", IsBinary = true)]
        MCD,

        [MimeTypeMetadata(Value = "text/vnd.curl.mcurl", IsText = true)]
        MCURL,

        [MimeTypeMetadata(Value = "application/x-msaccess", IsBinary = true)]
        MDB,

        [MimeTypeMetadata(Value = "image/vnd.ms-modi", IsBinary = true)]
        MDI,

        [MimeTypeMetadata(Value = "application/x-troff-me", IsBinary = true)]
        ME,

        [MimeTypeMetadata(Value = "model/mesh", IsBinary = true)]
        MESH,

        [MimeTypeMetadata(Value = "application/metalink4+xml", IsText = true)]
        META4,

        [MimeTypeMetadata(Value = "application/metalink+xml", IsText = true)]
        METALINK,

        [MimeTypeMetadata(Value = "application/mets+xml", IsText = true)]
        METS,

        [MimeTypeMetadata(Value = "application/vnd.mfmp", IsBinary = true)]
        MFM,

        [MimeTypeMetadata(Value = "application/rpki-manifest", IsBinary = true)]
        MFT,

        [MimeTypeMetadata(Value = "application/vnd.osgeo.mapguide.package", IsBinary = true)]
        MGP,

        [MimeTypeMetadata(Value = "application/vnd.proteus.magazine", IsBinary = true)]
        MGZ,

        [MimeTypeMetadata(Value = "audio/midi", IsBinary = true)]
        MID,

        [MimeTypeMetadata(Value = "audio/midi", IsBinary = true)]
        MIDI,

        [MimeTypeMetadata(Value = "application/x-mie", IsBinary = true)]
        MIE,

        [MimeTypeMetadata(Value = "application/vnd.mif", IsBinary = true)]
        MIF,

        [MimeTypeMetadata(Value = "message/rfc822", IsBinary = true)]
        MIME,

        [MimeTypeMetadata(Value = "video/mj2", IsBinary = true)]
        MJ2,

        [MimeTypeMetadata(Value = "video/mj2", IsBinary = true)]
        MJP2,

        [MimeTypeMetadata(Value = "video/x-matroska", IsBinary = true)]
        MK3D,

        [MimeTypeMetadata(Value = "audio/x-matroska", IsBinary = true)]
        MKA,

        [MimeTypeMetadata(Value = "video/x-matroska", IsBinary = true)]
        MKS,

        [MimeTypeMetadata(Value = "video/x-matroska", IsBinary = true)]
        MKV,

        [MimeTypeMetadata(Value = "application/vnd.dolby.mlp", IsBinary = true)]
        MLP,

        [MimeTypeMetadata(Value = "application/vnd.chipnuts.karaoke-mmd", IsBinary = true)]
        MMD,

        [MimeTypeMetadata(Value = "application/vnd.smaf", IsBinary = true)]
        MMF,

        [MimeTypeMetadata(Value = "image/vnd.fujixerox.edmics-mmr", IsBinary = true)]
        MMR,

        [MimeTypeMetadata(Value = "video/x-mng", IsBinary = true)]
        MNG,

        [MimeTypeMetadata(Value = "application/x-msmoney", IsBinary = true)]
        MNY,

        [MimeTypeMetadata(Value = "application/x-mobipocket-ebook", IsBinary = true)]
        MOBI,

        [MimeTypeMetadata(Value = "application/mods+xml", IsText = true)]
        MODS,

        [MimeTypeMetadata(Value = "video/quicktime", IsBinary = true)]
        MOV,

        [MimeTypeMetadata(Value = "video/x-sgi-movie", IsBinary = true)]
        MOVIE,

        [MimeTypeMetadata(Value = "audio/mpeg", IsBinary = true)]
        MP2,

        [MimeTypeMetadata(Value = "application/mp21", IsBinary = true)]
        MP21,

        [MimeTypeMetadata(Value = "audio/mpeg", IsBinary = true)]
        MP2A,

        [MimeTypeMetadata(Value = "audio/mpeg", IsBinary = true)]
        MP3,

        [MimeTypeMetadata(Value = "video/mp4", IsBinary = true)]
        MP4,

        [MimeTypeMetadata(Value = "audio/mp4", IsBinary = true)]
        MP4A,

        [MimeTypeMetadata(Value = "application/mp4", IsBinary = true)]
        MP4S,

        [MimeTypeMetadata(Value = "video/mp4", IsBinary = true)]
        MP4V,

        [MimeTypeMetadata(Value = "application/vnd.mophun.certificate", IsBinary = true)]
        MPC,

        [MimeTypeMetadata(Value = "video/mpeg", IsBinary = true)]
        MPE,

        [MimeTypeMetadata(Value = "video/mpeg", IsBinary = true)]
        MPEG,

        [MimeTypeMetadata(Value = "video/mpeg", IsBinary = true)]
        MPG,

        [MimeTypeMetadata(Value = "video/mp4", IsBinary = true)]
        MPG4,

        [MimeTypeMetadata(Value = "audio/mpeg", IsBinary = true)]
        MPGA,

        [MimeTypeMetadata(Value = "application/vnd.apple.installer+xml", IsText = true)]
        MPKG,

        [MimeTypeMetadata(Value = "application/vnd.blueice.multipass", IsBinary = true)]
        MPM,

        [MimeTypeMetadata(Value = "application/vnd.mophun.application", IsBinary = true)]
        MPN,

        [MimeTypeMetadata(Value = "application/vnd.ms-project", IsBinary = true)]
        MPP,

        [MimeTypeMetadata(Value = "application/vnd.ms-project", IsBinary = true)]
        MPT,

        [MimeTypeMetadata(Value = "application/vnd.ibm.minipay", IsBinary = true)]
        MPY,

        [MimeTypeMetadata(Value = "application/vnd.mobius.mqy", IsBinary = true)]
        MQY,

        [MimeTypeMetadata(Value = "application/marc", IsBinary = true)]
        MRC,

        [MimeTypeMetadata(Value = "application/marcxml+xml", IsText = true)]
        MRCX,

        [MimeTypeMetadata(Value = "application/x-troff-ms", IsBinary = true)]
        MS,

        [MimeTypeMetadata(Value = "application/mediaservercontrol+xml", IsText = true)]
        MSCML,

        [MimeTypeMetadata(Value = "application/vnd.fdsn.mseed", IsBinary = true)]
        MSEED,

        [MimeTypeMetadata(Value = "application/vnd.mseq", IsBinary = true)]
        MSEQ,

        [MimeTypeMetadata(Value = "application/vnd.epson.msf", IsBinary = true)]
        MSF,

        [MimeTypeMetadata(Value = "model/mesh", IsBinary = true)]
        MSH,

        [MimeTypeMetadata(Value = "application/x-msdownload", IsBinary = true)]
        MSI,

        [MimeTypeMetadata(Value = "application/vnd.mobius.msl", IsBinary = true)]
        MSL,

        [MimeTypeMetadata(Value = "application/vnd.muvee.style", IsBinary = true)]
        MSTY,

        [MimeTypeMetadata(Value = "model/vnd.mts", IsBinary = true)]
        MTS,

        [MimeTypeMetadata(Value = "application/vnd.musician", IsBinary = true)]
        MUS,

        [MimeTypeMetadata(Value = "application/vnd.recordare.musicxml+xml", IsText = true)]
        MUSICXML,

        [MimeTypeMetadata(Value = "application/x-msmediaview", IsBinary = true)]
        MVB,

        [MimeTypeMetadata(Value = "application/vnd.mfer", IsBinary = true)]
        MWF,

        [MimeTypeMetadata(Value = "application/mxf", IsBinary = true)]
        MXF,

        [MimeTypeMetadata(Value = "application/vnd.recordare.musicxml", IsText = true)]
        MXL,

        [MimeTypeMetadata(Value = "application/xv+xml", IsText = true)]
        MXML,

        [MimeTypeMetadata(Value = "application/vnd.triscape.mxs", IsBinary = true)]
        MXS,

        [MimeTypeMetadata(Value = "video/vnd.mpegurl", IsBinary = true)]
        MXU,

        [MimeTypeMetadata(Value = "text/n3", IsText = true)]
        N3,

        [MimeTypeMetadata(Value = "application/mathematica", IsBinary = true)]
        NB,

        [MimeTypeMetadata(Value = "application/vnd.wolfram.player", IsBinary = true)]
        NBP,

        [MimeTypeMetadata(Value = "application/x-netcdf", IsBinary = true)]
        NC,

        [MimeTypeMetadata(Value = "application/x-dtbncx+xml", IsText = true)]
        NCX,

        [MimeTypeMetadata(Value = "text/x-nfo", IsText = true)]
        NFO,

        [MimeTypeMetadata(Value = "application/vnd.nokia.n-gage.data", IsBinary = true)]
        NGDAT,

        [MimeTypeMetadata(Value = "application/vnd.nitf", IsBinary = true)]
        NITF,

        [MimeTypeMetadata(Value = "application/vnd.neurolanguage.nlu", IsBinary = true)]
        NLU,

        [MimeTypeMetadata(Value = "application/vnd.enliven", IsBinary = true)]
        NML,

        [MimeTypeMetadata(Value = "application/vnd.noblenet-directory", IsBinary = true)]
        NND,

        [MimeTypeMetadata(Value = "application/vnd.noblenet-sealer", IsBinary = true)]
        NNS,

        [MimeTypeMetadata(Value = "application/vnd.noblenet-web", IsBinary = true)]
        NNW,

        [MimeTypeMetadata(Value = "image/vnd.net-fpx", IsBinary = true)]
        NPX,

        [MimeTypeMetadata(Value = "application/x-conference", IsBinary = true)]
        NSC,

        [MimeTypeMetadata(Value = "application/vnd.lotus-notes", IsBinary = true)]
        NSF,

        [MimeTypeMetadata(Value = "application/vnd.nitf", IsBinary = true)]
        NTF,

        [MimeTypeMetadata(Value = "application/x-nzb", IsBinary = true)]
        NZB,

        [MimeTypeMetadata(Value = "application/vnd.fujitsu.oasys2", IsBinary = true)]
        OA2,

        [MimeTypeMetadata(Value = "application/vnd.fujitsu.oasys3", IsBinary = true)]
        OA3,

        [MimeTypeMetadata(Value = "application/vnd.fujitsu.oasys", IsBinary = true)]
        OAS,

        [MimeTypeMetadata(Value = "application/x-msbinder", IsBinary = true)]
        OBD,

        [MimeTypeMetadata(Value = "application/x-tgif", IsBinary = true)]
        OBJ,

        [MimeTypeMetadata(Value = "application/oda", IsBinary = true)]
        ODA,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.database", IsBinary = true)]
        ODB,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.chart", IsBinary = true)]
        ODC,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.formula", IsBinary = true)]
        ODF,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.formula-template", IsBinary = true)]
        ODFT,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.graphics", IsBinary = true)]
        ODG,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.image", IsBinary = true)]
        ODI,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.text-master", IsBinary = true)]
        ODM,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.presentation", IsBinary = true)]
        ODP,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.spreadsheet", IsBinary = true)]
        ODS,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.text", IsBinary = true)]
        ODT,

        [MimeTypeMetadata(Value = "audio/ogg", IsBinary = true)]
        OGA,

        [MimeTypeMetadata(Value = "video/ogg", IsBinary = true)]
        OGG,

        [MimeTypeMetadata(Value = "video/ogg", IsBinary = true)]
        OGV,

        [MimeTypeMetadata(Value = "application/ogg", IsBinary = true)]
        OGX,

        [MimeTypeMetadata(Value = "application/omdoc+xml", IsText = true)]
        OMDOC,

        [MimeTypeMetadata(Value = "application/onenote", IsBinary = true)]
        ONEPKG,

        [MimeTypeMetadata(Value = "application/onenote", IsBinary = true)]
        ONETMP,

        [MimeTypeMetadata(Value = "application/onenote", IsBinary = true)]
        ONETOC,

        [MimeTypeMetadata(Value = "application/onenote", IsBinary = true)]
        ONETOC2,

        [MimeTypeMetadata(Value = "application/oebps-package+xml", IsText = true)]
        OPF,

        [MimeTypeMetadata(Value = "text/x-opml", IsText = true)]
        OPML,

        [MimeTypeMetadata(Value = "application/vnd.palm", IsBinary = true)]
        OPRC,

        [MimeTypeMetadata(Value = "application/vnd.lotus-organizer", IsBinary = true)]
        ORG,

        [MimeTypeMetadata(Value = "application/vnd.yamaha.openscoreformat", IsBinary = true)]
        OSF,

        [MimeTypeMetadata(Value = "application/vnd.yamaha.openscoreformat.osfpvg+xml", IsText = true)]
        OSFPVG,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.chart-template", IsBinary = true)]
        OTC,

        [MimeTypeMetadata(Value = "application/x-font-otf", IsBinary = true)]
        OTF,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.graphics-template", IsBinary = true)]
        OTG,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.text-web", IsBinary = true)]
        OTH,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.image-template", IsBinary = true)]
        OTI,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.presentation-template", IsBinary = true)]
        OTP,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.spreadsheet-template", IsBinary = true)]
        OTS,

        [MimeTypeMetadata(Value = "application/vnd.oasis.opendocument.text-template", IsBinary = true)]
        OTT,

        [MimeTypeMetadata(Value = "application/oxps", IsBinary = true)]
        OXPS,

        [MimeTypeMetadata(Value = "application/vnd.openofficeorg.extension", IsBinary = true)]
        OXT,

        [MimeTypeMetadata(Value = "text/x-pascal", IsText = true)]
        P,

        [MimeTypeMetadata(Value = "application/pkcs10", IsBinary = true)]
        P10,

        [MimeTypeMetadata(Value = "application/x-pkcs12", IsBinary = true)]
        P12,

        [MimeTypeMetadata(Value = "application/x-pkcs7-certificates", IsBinary = true)]
        P7B,

        [MimeTypeMetadata(Value = "application/pkcs7-mime", IsBinary = true)]
        P7C,

        [MimeTypeMetadata(Value = "application/pkcs7-mime", IsBinary = true)]
        P7M,

        [MimeTypeMetadata(Value = "application/x-pkcs7-certreqresp", IsBinary = true)]
        P7R,

        [MimeTypeMetadata(Value = "application/pkcs7-signature", IsBinary = true)]
        P7S,

        [MimeTypeMetadata(Value = "application/pkcs8", IsBinary = true)]
        P8,

        [MimeTypeMetadata(Value = "text/x-pascal", IsText = true)]
        PAS,

        [MimeTypeMetadata(Value = "application/vnd.pawaafile", IsBinary = true)]
        PAW,

        [MimeTypeMetadata(Value = "application/vnd.powerbuilder6", IsBinary = true)]
        PBD,

        [MimeTypeMetadata(Value = "image/x-portable-bitmap", IsBinary = true)]
        PBM,

        [MimeTypeMetadata(Value = "application/vnd.tcpdump.pcap", IsBinary = true)]
        PCAP,

        [MimeTypeMetadata(Value = "application/x-font-pcf", IsBinary = true)]
        PCF,

        [MimeTypeMetadata(Value = "application/vnd.hp-pcl", IsBinary = true)]
        PCL,

        [MimeTypeMetadata(Value = "application/vnd.hp-pclxl", IsBinary = true)]
        PCLXL,

        [MimeTypeMetadata(Value = "image/x-pict", IsBinary = true)]
        PCT,

        [MimeTypeMetadata(Value = "application/vnd.curl.pcurl", IsBinary = true)]
        PCURL,

        [MimeTypeMetadata(Value = "image/x-pcx", IsBinary = true)]
        PCX,

        [MimeTypeMetadata(Value = "applicaton/octet-stream", IsBinary = true)]
        PDB,

        [MimeTypeMetadata(Value = "application/pdf", IsBinary = true)]
        PDF,

        [MimeTypeMetadata(Value = "application/x-font-type1", IsBinary = true)]
        PFA,

        [MimeTypeMetadata(Value = "application/x-font-type1", IsBinary = true)]
        PFB,

        [MimeTypeMetadata(Value = "application/x-font-type1", IsBinary = true)]
        PFM,

        [MimeTypeMetadata(Value = "application/font-tdpfr", IsBinary = true)]
        PFR,

        [MimeTypeMetadata(Value = "application/x-pkcs12", IsBinary = true)]
        PFX,

        [MimeTypeMetadata(Value = "image/x-portable-graymap", IsBinary = true)]
        PGM,

        [MimeTypeMetadata(Value = "application/x-chess-pgn", IsBinary = true)]
        PGN,

        [MimeTypeMetadata(Value = "application/pgp-encrypted", IsBinary = true)]
        PGP,

        [MimeTypeMetadata(Value = "image/x-pict", IsBinary = true)]
        PIC,

        [MimeTypeMetadata(Value = "image/pict", IsBinary = true)]
        PICT,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        PKG,

        [MimeTypeMetadata(Value = "application/pkixcmp", IsBinary = true)]
        PKI,

        [MimeTypeMetadata(Value = "application/pkix-pkipath", IsBinary = true)]
        PKIPATH,

        [MimeTypeMetadata(Value = "application/vnd.3gpp.pic-bw-large", IsBinary = true)]
        PLB,

        [MimeTypeMetadata(Value = "application/vnd.mobius.plc", IsBinary = true)]
        PLC,

        [MimeTypeMetadata(Value = "application/vnd.pocketlearn", IsBinary = true)]
        PLF,

        [MimeTypeMetadata(Value = "application/pls+xml", IsText = true)]
        PLS,

        [MimeTypeMetadata(Value = "application/vnd.ctc-posml", IsBinary = true)]
        PML,

        [MimeTypeMetadata(Value = "image/png", IsBinary = true)]
        PNG,

        [MimeTypeMetadata(Value = "image/x-portable-anymap", IsBinary = true)]
        PNM,

        [MimeTypeMetadata(Value = "image/x-macpaint", IsBinary = true)]
        PNT,

        [MimeTypeMetadata(Value = "image/x-macpaint", IsBinary = true)]
        PNTG,

        [MimeTypeMetadata(Value = "application/vnd.macports.portpkg", IsBinary = true)]
        PORTPKG,

        [MimeTypeMetadata(Value = "application/vnd.ms-powerpoint", IsBinary = true)]
        POT,

        [MimeTypeMetadata(Value = "application/vnd.ms-powerpoint.template.macroenabled.12", IsBinary = true)]
        POTM,

        [MimeTypeMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.template", IsBinary = true)]
        POTX,

        [MimeTypeMetadata(Value = "application/vnd.ms-powerpoint.addin.macroenabled.12", IsBinary = true)]
        PPAM,

        [MimeTypeMetadata(Value = "application/vnd.cups-ppd", IsBinary = true)]
        PPD,

        [MimeTypeMetadata(Value = "image/x-portable-pixmap", IsBinary = true)]
        PPM,

        [MimeTypeMetadata(Value = "application/vnd.ms-powerpoint", IsBinary = true)]
        PPS,

        [MimeTypeMetadata(Value = "application/vnd.ms-powerpoint.slideshow.macroenabled.12", IsBinary = true)]
        PPSM,

        [MimeTypeMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.slideshow", IsBinary = true)]
        PPSX,

        [MimeTypeMetadata(Value = "application/vnd.ms-powerpoint", IsBinary = true)]
        PPT,

        [MimeTypeMetadata(Value = "application/vnd.ms-powerpoint.presentation.macroenabled.12", IsBinary = true)]
        PPTM,

        [MimeTypeMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.presentation", IsBinary = true)]
        PPTX,

        [MimeTypeMetadata(Value = "application/vnd.palm", IsBinary = true)]
        PQA,

        [MimeTypeMetadata(Value = "application/x-mobipocket-ebook", IsBinary = true)]
        PRC,

        [MimeTypeMetadata(Value = "application/vnd.lotus-freelance", IsBinary = true)]
        PRE,

        [MimeTypeMetadata(Value = "application/pics-rules", IsBinary = true)]
        PRF,

        [MimeTypeMetadata(Value = "application/postscript", IsBinary = true)]
        PS,

        [MimeTypeMetadata(Value = "application/vnd.3gpp.pic-bw-small", IsBinary = true)]
        PSB,

        [MimeTypeMetadata(Value = "image/vnd.adobe.photoshop", IsBinary = true)]
        PSD,

        [MimeTypeMetadata(Value = "application/x-font-linux-psf", IsBinary = true)]
        PSF,

        [MimeTypeMetadata(Value = "application/pskc+xml", IsText = true)]
        PSKCXML,

        [MimeTypeMetadata(Value = "application/vnd.pvi.ptid1", IsBinary = true)]
        PTID,

        [MimeTypeMetadata(Value = "application/x-mspublisher", IsBinary = true)]
        PUB,

        [MimeTypeMetadata(Value = "application/vnd.3gpp.pic-bw-var", IsBinary = true)]
        PVB,

        [MimeTypeMetadata(Value = "application/vnd.3m.post-it-notes", IsBinary = true)]
        PWN,

        [MimeTypeMetadata(Value = "audio/vnd.ms-playready.media.pya", IsBinary = true)]
        PYA,

        [MimeTypeMetadata(Value = "video/vnd.ms-playready.media.pyv", IsBinary = true)]
        PYV,

        [MimeTypeMetadata(Value = "application/vnd.epson.quickanime", IsBinary = true)]
        QAM,

        [MimeTypeMetadata(Value = "application/vnd.intu.qbo", IsBinary = true)]
        QBO,

        [MimeTypeMetadata(Value = "application/vnd.intu.qfx", IsBinary = true)]
        QFX,

        [MimeTypeMetadata(Value = "application/vnd.publishare-delta-tree", IsBinary = true)]
        QPS,

        [MimeTypeMetadata(Value = "video/quicktime", IsBinary = true)]
        QT,

        [MimeTypeMetadata(Value = "image/x-quicktime", IsBinary = true)]
        QTI,

        [MimeTypeMetadata(Value = "image/x-quicktime", IsBinary = true)]
        QTIF,

        [MimeTypeMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QWD,

        [MimeTypeMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QWT,

        [MimeTypeMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXB,

        [MimeTypeMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXD,

        [MimeTypeMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXL,

        [MimeTypeMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXT,

        [MimeTypeMetadata(Value = "audio/x-pn-realaudio", IsBinary = true)]
        RA,

        [MimeTypeMetadata(Value = "audio/x-pn-realaudio", IsBinary = true)]
        RAM,

        [MimeTypeMetadata(Value = "application/x-rar-compressed", IsBinary = true)]
        RAR,

        [MimeTypeMetadata(Value = "image/x-cmu-raster", IsBinary = true)]
        RAS,

        [MimeTypeMetadata(Value = "application/vnd.ipunplugged.rcprofile", IsBinary = true)]
        RCPROFILE,

        [MimeTypeMetadata(Value = "application/rdf+xml", IsText = true)]
        RDF,

        [MimeTypeMetadata(Value = "application/vnd.data-vision.rdz", IsBinary = true)]
        RDZ,

        [MimeTypeMetadata(Value = "application/vnd.businessobjects", IsBinary = true)]
        REP,

        [MimeTypeMetadata(Value = "application/x-dtbresource+xml", IsText = true)]
        RES,

        [MimeTypeMetadata(Value = "image/x-rgb", IsBinary = true)]
        RGB,

        [MimeTypeMetadata(Value = "application/reginfo+xml", IsText = true)]
        RIF,

        [MimeTypeMetadata(Value = "audio/vnd.rip", IsBinary = true)]
        RIP,

        [MimeTypeMetadata(Value = "application/x-research-info-systems", IsBinary = true)]
        RIS,

        [MimeTypeMetadata(Value = "application/resource-lists+xml", IsText = true)]
        RL,

        [MimeTypeMetadata(Value = "image/vnd.fujixerox.edmics-rlc", IsBinary = true)]
        RLC,

        [MimeTypeMetadata(Value = "application/resource-lists-diff+xml", IsText = true)]
        RLD,

        [MimeTypeMetadata(Value = "application/vnd.rn-realmedia", IsBinary = true)]
        RM,

        [MimeTypeMetadata(Value = "audio/midi", IsBinary = true)]
        RMI,

        [MimeTypeMetadata(Value = "audio/x-pn-realaudio-plugin", IsBinary = true)]
        RMP,

        [MimeTypeMetadata(Value = "application/vnd.jcp.javame.midlet-rms", IsBinary = true)]
        RMS,

        [MimeTypeMetadata(Value = "application/vnd.rn-realmedia-vbr", IsBinary = true)]
        RMVB,

        [MimeTypeMetadata(Value = "application/relax-ng-compact-syntax", IsBinary = true)]
        RNC,

        [MimeTypeMetadata(Value = "application/rpki-roa", IsBinary = true)]
        ROA,

        [MimeTypeMetadata(Value = "application/x-troff", IsBinary = true)]
        ROFF,

        [MimeTypeMetadata(Value = "application/vnd.cloanto.rp9", IsBinary = true)]
        RP9,

        [MimeTypeMetadata(Value = "application/vnd.nokia.radio-presets", IsBinary = true)]
        RPSS,

        [MimeTypeMetadata(Value = "application/vnd.nokia.radio-preset", IsBinary = true)]
        RPST,

        [MimeTypeMetadata(Value = "application/sparql-query", IsBinary = true)]
        RQ,

        [MimeTypeMetadata(Value = "application/rls-services+xml", IsText = true)]
        RS,

        [MimeTypeMetadata(Value = "application/rsd+xml", IsText = true)]
        RSD,

        [MimeTypeMetadata(Value = "application/rss+xml", IsText = true)]
        RSS,

        [MimeTypeMetadata(Value = "application/rtf", IsBinary = true)]
        RTF,

        [MimeTypeMetadata(Value = "text/richtext", IsText = true)]
        RTX,

        [MimeTypeMetadata(Value = "text/x-asm", IsText = true)]
        S,

        [MimeTypeMetadata(Value = "audio/s3m", IsBinary = true)]
        S3M,

        [MimeTypeMetadata(Value = "application/vnd.yamaha.smaf-audio", IsBinary = true)]
        SAF,

        [MimeTypeMetadata(Value = "application/sbml+xml", IsText = true)]
        SBML,

        [MimeTypeMetadata(Value = "application/vnd.ibm.secure-container", IsBinary = true)]
        SC,

        [MimeTypeMetadata(Value = "application/x-msschedule", IsBinary = true)]
        SCD,

        [MimeTypeMetadata(Value = "application/vnd.lotus-screencam", IsBinary = true)]
        SCM,

        [MimeTypeMetadata(Value = "application/scvp-cv-request", IsBinary = true)]
        SCQ,

        [MimeTypeMetadata(Value = "application/scvp-cv-response", IsBinary = true)]
        SCS,

        [MimeTypeMetadata(Value = "text/vnd.curl.scurl", IsText = true)]
        SCURL,

        [MimeTypeMetadata(Value = "application/vnd.stardivision.draw", IsBinary = true)]
        SDA,

        [MimeTypeMetadata(Value = "application/vnd.stardivision.calc", IsBinary = true)]
        SDC,

        [MimeTypeMetadata(Value = "application/vnd.stardivision.impress", IsBinary = true)]
        SDD,

        [MimeTypeMetadata(Value = "application/vnd.solent.sdkm+xml", IsText = true)]
        SDKD,

        [MimeTypeMetadata(Value = "application/vnd.solent.sdkm+xml", IsText = true)]
        SDKM,

        [MimeTypeMetadata(Value = "application/sdp", IsBinary = true)]
        SDP,

        [MimeTypeMetadata(Value = "application/vnd.stardivision.writer", IsBinary = true)]
        SDW,

        [MimeTypeMetadata(Value = "application/vnd.seemail", IsBinary = true)]
        SEE,

        [MimeTypeMetadata(Value = "application/vnd.fdsn.seed", IsBinary = true)]
        SEED,

        [MimeTypeMetadata(Value = "application/vnd.sema", IsBinary = true)]
        SEMA,

        [MimeTypeMetadata(Value = "application/vnd.semd", IsBinary = true)]
        SEMD,

        [MimeTypeMetadata(Value = "application/vnd.semf", IsBinary = true)]
        SEMF,

        [MimeTypeMetadata(Value = "application/java-serialized-object", IsBinary = true)]
        SER,

        [MimeTypeMetadata(Value = "application/set-payment-initiation", IsBinary = true)]
        SETPAY,

        [MimeTypeMetadata(Value = "application/set-registration-initiation", IsBinary = true)]
        SETREG,

        [MimeTypeMetadata(Value = "application/vnd.spotfire.sfs", IsBinary = true)]
        SFS,

        [MimeTypeMetadata(Value = "text/x-sfv", IsText = true)]
        SFV,

        [MimeTypeMetadata(Value = "image/sgi", IsBinary = true)]
        SGI,

        [MimeTypeMetadata(Value = "application/vnd.stardivision.writer-global", IsBinary = true)]
        SGL,

        [MimeTypeMetadata(Value = "text/sgml", IsText = true)]
        SGM,

        [MimeTypeMetadata(Value = "text/sgml", IsText = true)]
        SGML,

        [MimeTypeMetadata(Value = "application/x-sh", IsBinary = true)]
        SH,

        [MimeTypeMetadata(Value = "application/x-shar", IsBinary = true)]
        SHAR,

        [MimeTypeMetadata(Value = "application/shf+xml", IsText = true)]
        SHF,

        [MimeTypeMetadata(Value = "image/x-mrsid-image", IsBinary = true)]
        SID,

        [MimeTypeMetadata(Value = "application/pgp-signature", IsBinary = true)]
        SIG,

        [MimeTypeMetadata(Value = "audio/silk", IsBinary = true)]
        SIL,

        [MimeTypeMetadata(Value = "model/mesh", IsBinary = true)]
        SILO,

        [MimeTypeMetadata(Value = "application/vnd.symbian.install", IsBinary = true)]
        SIS,

        [MimeTypeMetadata(Value = "application/vnd.symbian.install", IsBinary = true)]
        SISX,

        [MimeTypeMetadata(Value = "application/x-stuffit", IsBinary = true)]
        SIT,

        [MimeTypeMetadata(Value = "application/x-stuffitx", IsBinary = true)]
        SITX,

        [MimeTypeMetadata(Value = "application/x-koan", IsBinary = true)]
        SKD,

        [MimeTypeMetadata(Value = "application/x-koan", IsBinary = true)]
        SKM,

        [MimeTypeMetadata(Value = "application/x-koan", IsBinary = true)]
        SKP,

        [MimeTypeMetadata(Value = "application/x-koan", IsBinary = true)]
        SKT,

        [MimeTypeMetadata(Value = "application/vnd.ms-powerpoint.slide.macroenabled.12", IsBinary = true)]
        SLDM,

        [MimeTypeMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.slide", IsBinary = true)]
        SLDX,

        [MimeTypeMetadata(Value = "application/vnd.epson.salt", IsBinary = true)]
        SLT,

        [MimeTypeMetadata(Value = "application/vnd.stepmania.stepchart", IsBinary = true)]
        SM,

        [MimeTypeMetadata(Value = "application/vnd.stardivision.math", IsBinary = true)]
        SMF,

        [MimeTypeMetadata(Value = "application/smil+xml", IsText = true)]
        SMI,

        [MimeTypeMetadata(Value = "application/smil+xml", IsText = true)]
        SMIL,

        [MimeTypeMetadata(Value = "video/x-smv", IsBinary = true)]
        SMV,

        [MimeTypeMetadata(Value = "application/vnd.stepmania.package", IsBinary = true)]
        SMZIP,

        [MimeTypeMetadata(Value = "audio/basic", IsBinary = true)]
        SND,

        [MimeTypeMetadata(Value = "application/x-font-snf", IsBinary = true)]
        SNF,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        SO,

        [MimeTypeMetadata(Value = "application/x-pkcs7-certificates", IsBinary = true)]
        SPC,

        [MimeTypeMetadata(Value = "application/vnd.yamaha.smaf-phrase", IsBinary = true)]
        SPF,

        [MimeTypeMetadata(Value = "application/x-futuresplash", IsBinary = true)]
        SPL,

        [MimeTypeMetadata(Value = "text/vnd.in3d.spot", IsText = true)]
        SPOT,

        [MimeTypeMetadata(Value = "application/scvp-vp-response", IsBinary = true)]
        SPP,

        [MimeTypeMetadata(Value = "application/scvp-vp-request", IsBinary = true)]
        SPQ,

        [MimeTypeMetadata(Value = "audio/ogg", IsBinary = true)]
        SPX,

        [MimeTypeMetadata(Value = "application/x-sql", IsBinary = true)]
        SQL,

        [MimeTypeMetadata(Value = "application/x-wais-source", IsBinary = true)]
        SRC,

        [MimeTypeMetadata(Value = "application/x-subrip", IsBinary = true)]
        SRT,

        [MimeTypeMetadata(Value = "application/sru+xml", IsText = true)]
        SRU,

        [MimeTypeMetadata(Value = "application/sparql-results+xml", IsText = true)]
        SRX,

        [MimeTypeMetadata(Value = "application/ssdl+xml", IsText = true)]
        SSDL,

        [MimeTypeMetadata(Value = "application/vnd.kodak-descriptor", IsBinary = true)]
        SSE,

        [MimeTypeMetadata(Value = "application/vnd.epson.ssf", IsBinary = true)]
        SSF,

        [MimeTypeMetadata(Value = "application/ssml+xml", IsText = true)]
        SSML,

        [MimeTypeMetadata(Value = "application/vnd.sailingtracker.track", IsBinary = true)]
        ST,

        [MimeTypeMetadata(Value = "application/vnd.sun.xml.calc.template", IsBinary = true)]
        STC,

        [MimeTypeMetadata(Value = "application/vnd.sun.xml.draw.template", IsBinary = true)]
        STD,

        [MimeTypeMetadata(Value = "application/vnd.wt.stf", IsBinary = true)]
        STF,

        [MimeTypeMetadata(Value = "application/vnd.sun.xml.impress.template", IsBinary = true)]
        STI,

        [MimeTypeMetadata(Value = "application/hyperstudio", IsBinary = true)]
        STK,

        [MimeTypeMetadata(Value = "application/vnd.ms-pki.stl", IsBinary = true)]
        STL,

        [MimeTypeMetadata(Value = "application/vnd.pg.format", IsBinary = true)]
        STR,

        [MimeTypeMetadata(Value = "application/vnd.sun.xml.writer.template", IsBinary = true)]
        STW,

        [MimeTypeMetadata(Value = "text/vnd.dvb.subtitle", IsText = true)]
        SUB,

        [MimeTypeMetadata(Value = "application/vnd.sus-calendar", IsBinary = true)]
        SUS,

        [MimeTypeMetadata(Value = "application/vnd.sus-calendar", IsBinary = true)]
        SUSP,

        [MimeTypeMetadata(Value = "application/x-sv4cpio", IsBinary = true)]
        SV4CPIO,

        [MimeTypeMetadata(Value = "application/x-sv4crc", IsBinary = true)]
        SV4CRC,

        [MimeTypeMetadata(Value = "application/vnd.dvb.service", IsBinary = true)]
        SVC,

        [MimeTypeMetadata(Value = "application/vnd.svd", IsBinary = true)]
        SVD,

        [MimeTypeMetadata(Value = "image/svg+xml", IsText = true)]
        SVG,

        [MimeTypeMetadata(Value = "image/svg+xml", IsText = true)]
        SVGZ,

        [MimeTypeMetadata(Value = "application/x-director", IsBinary = true)]
        SWA,

        [MimeTypeMetadata(Value = "application/x-shockwave-flash", IsBinary = true)]
        SWF,

        [MimeTypeMetadata(Value = "application/vnd.aristanetworks.swi", IsBinary = true)]
        SWI,

        [MimeTypeMetadata(Value = "application/vnd.sun.xml.calc", IsBinary = true)]
        SXC,

        [MimeTypeMetadata(Value = "application/vnd.sun.xml.draw", IsBinary = true)]
        SXD,

        [MimeTypeMetadata(Value = "application/vnd.sun.xml.writer.global", IsBinary = true)]
        SXG,

        [MimeTypeMetadata(Value = "application/vnd.sun.xml.impress", IsBinary = true)]
        SXI,

        [MimeTypeMetadata(Value = "application/vnd.sun.xml.math", IsBinary = true)]
        SXM,

        [MimeTypeMetadata(Value = "application/vnd.sun.xml.writer", IsBinary = true)]
        SXW,

        [MimeTypeMetadata(Value = "application/x-troff", IsBinary = true)]
        T,

        [MimeTypeMetadata(Value = "application/x-t3vm-image", IsBinary = true)]
        T3,

        [MimeTypeMetadata(Value = "application/vnd.mynfc", IsBinary = true)]
        TAGLET,

        [MimeTypeMetadata(Value = "application/vnd.tao.intent-module-archive", IsBinary = true)]
        TAO,

        [MimeTypeMetadata(Value = "application/x-tar", IsBinary = true)]
        TAR,

        [MimeTypeMetadata(Value = "application/vnd.3gpp2.tcap", IsBinary = true)]
        TCAP,

        [MimeTypeMetadata(Value = "application/x-tcl", IsBinary = true)]
        TCL,

        [MimeTypeMetadata(Value = "application/vnd.smart.teacher", IsBinary = true)]
        TEACHER,

        [MimeTypeMetadata(Value = "application/tei+xml", IsText = true)]
        TEI,

        [MimeTypeMetadata(Value = "application/tei+xml", IsText = true)]
        TEICORPUS,

        [MimeTypeMetadata(Value = "application/x-tex", IsBinary = true)]
        TEX,

        [MimeTypeMetadata(Value = "application/x-texinfo", IsBinary = true)]
        TEXI,

        [MimeTypeMetadata(Value = "application/x-texinfo", IsBinary = true)]
        TEXINFO,

        [MimeTypeMetadata(Value = "text/plain", IsText = true)]
        TEXT,

        [MimeTypeMetadata(Value = "application/thraud+xml", IsText = true)]
        TFI,

        [MimeTypeMetadata(Value = "application/x-tex-tfm", IsBinary = true)]
        TFM,

        [MimeTypeMetadata(Value = "image/x-tga", IsBinary = true)]
        TGA,

        [MimeTypeMetadata(Value = "application/vnd.ms-officetheme", IsBinary = true)]
        THMX,

        [MimeTypeMetadata(Value = "image/tiff", IsBinary = true)]
        TIF,

        [MimeTypeMetadata(Value = "image/tiff", IsBinary = true)]
        TIFF,

        [MimeTypeMetadata(Value = "application/vnd.tmobile-livetv", IsBinary = true)]
        TMO,

        [MimeTypeMetadata(Value = "application/x-bittorrent", IsBinary = true)]
        TORRENT,

        [MimeTypeMetadata(Value = "application/vnd.groove-tool-template", IsBinary = true)]
        TPL,

        [MimeTypeMetadata(Value = "application/vnd.trid.tpt", IsBinary = true)]
        TPT,

        [MimeTypeMetadata(Value = "application/x-troff", IsBinary = true)]
        TR,

        [MimeTypeMetadata(Value = "application/vnd.trueapp", IsBinary = true)]
        TRA,

        [MimeTypeMetadata(Value = "application/x-msterminal", IsBinary = true)]
        TRM,

        [MimeTypeMetadata(Value = "application/timestamped-data", IsBinary = true)]
        TSD,

        [MimeTypeMetadata(Value = "text/tab-separated-values", IsText = true)]
        TSV,

        [MimeTypeMetadata(Value = "application/x-font-ttf", IsBinary = true)]
        TTC,

        [MimeTypeMetadata(Value = "application/x-font-ttf", IsBinary = true)]
        TTF,

        [MimeTypeMetadata(Value = "text/turtle", IsText = true)]
        TTL,

        [MimeTypeMetadata(Value = "application/vnd.simtech-mindmapper", IsBinary = true)]
        TWD,

        [MimeTypeMetadata(Value = "application/vnd.simtech-mindmapper", IsBinary = true)]
        TWDS,

        [MimeTypeMetadata(Value = "application/vnd.genomatix.tuxedo", IsBinary = true)]
        TXD,

        [MimeTypeMetadata(Value = "application/vnd.mobius.txf", IsBinary = true)]
        TXF,

        [MimeTypeMetadata(Value = "text/plain", IsText = true)]
        TXT,

        [MimeTypeMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        U32,

        [MimeTypeMetadata(Value = "application/x-debian-package", IsBinary = true)]
        UDEB,

        [MimeTypeMetadata(Value = "application/vnd.ufdl", IsBinary = true)]
        UFD,

        [MimeTypeMetadata(Value = "application/vnd.ufdl", IsBinary = true)]
        UFDL,

        [MimeTypeMetadata(Value = "application/x-glulx", IsBinary = true)]
        ULX,

        [MimeTypeMetadata(Value = "application/vnd.umajin", IsBinary = true)]
        UMJ,

        [MimeTypeMetadata(Value = "application/vnd.unity", IsBinary = true)]
        UNITYWEB,

        [MimeTypeMetadata(Value = "application/vnd.uoml+xml", IsText = true)]
        UOML,

        [MimeTypeMetadata(Value = "text/uri-list", IsText = true)]
        URI,

        [MimeTypeMetadata(Value = "text/uri-list", IsText = true)]
        URIS,

        [MimeTypeMetadata(Value = "text/uri-list", IsText = true)]
        URLS,

        [MimeTypeMetadata(Value = "application/x-ustar", IsBinary = true)]
        USTAR,

        [MimeTypeMetadata(Value = "application/vnd.uiq.theme", IsBinary = true)]
        UTZ,

        [MimeTypeMetadata(Value = "text/x-uuencode", IsText = true)]
        UU,

        [MimeTypeMetadata(Value = "audio/vnd.dece.audio", IsBinary = true)]
        UVA,

        [MimeTypeMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVD,

        [MimeTypeMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVF,

        [MimeTypeMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVG,

        [MimeTypeMetadata(Value = "video/vnd.dece.hd", IsBinary = true)]
        UVH,

        [MimeTypeMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVI,

        [MimeTypeMetadata(Value = "video/vnd.dece.mobile", IsBinary = true)]
        UVM,

        [MimeTypeMetadata(Value = "video/vnd.dece.pd", IsBinary = true)]
        UVP,

        [MimeTypeMetadata(Value = "video/vnd.dece.sd", IsBinary = true)]
        UVS,

        [MimeTypeMetadata(Value = "application/vnd.dece.ttml+xml", IsText = true)]
        UVT,

        [MimeTypeMetadata(Value = "video/vnd.uvvu.mp4", IsBinary = true)]
        UVU,

        [MimeTypeMetadata(Value = "video/vnd.dece.video", IsBinary = true)]
        UVV,

        [MimeTypeMetadata(Value = "audio/vnd.dece.audio", IsBinary = true)]
        UVVA,

        [MimeTypeMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVVD,

        [MimeTypeMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVVF,

        [MimeTypeMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVVG,

        [MimeTypeMetadata(Value = "video/vnd.dece.hd", IsBinary = true)]
        UVVH,

        [MimeTypeMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVVI,

        [MimeTypeMetadata(Value = "video/vnd.dece.mobile", IsBinary = true)]
        UVVM,

        [MimeTypeMetadata(Value = "video/vnd.dece.pd", IsBinary = true)]
        UVVP,

        [MimeTypeMetadata(Value = "video/vnd.dece.sd", IsBinary = true)]
        UVVS,

        [MimeTypeMetadata(Value = "application/vnd.dece.ttml+xml", IsText = true)]
        UVVT,

        [MimeTypeMetadata(Value = "video/vnd.uvvu.mp4", IsBinary = true)]
        UVVU,

        [MimeTypeMetadata(Value = "video/vnd.dece.video", IsBinary = true)]
        UVVV,

        [MimeTypeMetadata(Value = "application/vnd.dece.unspecified", IsBinary = true)]
        UVVX,

        [MimeTypeMetadata(Value = "application/vnd.dece.zip", IsBinary = true)]
        UVVZ,

        [MimeTypeMetadata(Value = "application/vnd.dece.unspecified", IsBinary = true)]
        UVX,

        [MimeTypeMetadata(Value = "application/vnd.dece.zip", IsBinary = true)]
        UVZ,

        [MimeTypeMetadata(Value = "text/vcard", IsText = true)]
        VCARD,

        [MimeTypeMetadata(Value = "application/x-cdlink", IsBinary = true)]
        VCD,

        [MimeTypeMetadata(Value = "text/x-vcard", IsText = true)]
        VCF,

        [MimeTypeMetadata(Value = "application/vnd.groove-vcard", IsBinary = true)]
        VCG,

        [MimeTypeMetadata(Value = "text/x-vcalendar", IsText = true)]
        VCS,

        [MimeTypeMetadata(Value = "application/vnd.vcx", IsBinary = true)]
        VCX,

        [MimeTypeMetadata(Value = "application/vnd.visionary", IsBinary = true)]
        VIS,

        [MimeTypeMetadata(Value = "video/vnd.vivo", IsBinary = true)]
        VIV,

        [MimeTypeMetadata(Value = "video/x-ms-vob", IsBinary = true)]
        VOB,

        [MimeTypeMetadata(Value = "application/vnd.stardivision.writer", IsBinary = true)]
        VOR,

        [MimeTypeMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        VOX,

        [MimeTypeMetadata(Value = "model/vrml", IsBinary = true)]
        VRML,

        [MimeTypeMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VSD,

        [MimeTypeMetadata(Value = "application/vnd.vsf", IsBinary = true)]
        VSF,

        [MimeTypeMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VSS,

        [MimeTypeMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VST,

        [MimeTypeMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VSW,

        [MimeTypeMetadata(Value = "model/vnd.vtu", IsBinary = true)]
        VTU,

        [MimeTypeMetadata(Value = "application/voicexml+xml", IsText = true)]
        VXML,

        [MimeTypeMetadata(Value = "application/x-director", IsBinary = true)]
        W3D,

        [MimeTypeMetadata(Value = "application/x-doom", IsBinary = true)]
        WAD,

        [MimeTypeMetadata(Value = "audio/x-wav", IsBinary = true)]
        WAV,

        [MimeTypeMetadata(Value = "audio/x-ms-wax", IsBinary = true)]
        WAX,

        [MimeTypeMetadata(Value = "image/vnd.wap.wbmp", IsBinary = true)]
        WBMP,

        [MimeTypeMetadata(Value = "application/vnd.wap.wbxml", IsText = true)]
        WBMXL,

        [MimeTypeMetadata(Value = "application/vnd.criticaltools.wbs+xml", IsText = true)]
        WBS,

        [MimeTypeMetadata(Value = "application/vnd.wap.wbxml", IsText = true)]
        WBXML,

        [MimeTypeMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WCM,

        [MimeTypeMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WDB,

        [MimeTypeMetadata(Value = "image/vnd.ms-photo", IsBinary = true)]
        WDP,

        [MimeTypeMetadata(Value = "audio/webm", IsBinary = true)]
        WEBA,

        [MimeTypeMetadata(Value = "video/webm", IsBinary = true)]
        WEBM,

        [MimeTypeMetadata(Value = "image/webp", IsBinary = true)]
        WEBP,

        [MimeTypeMetadata(Value = "application/vnd.pmi.widget", IsBinary = true)]
        WG,

        [MimeTypeMetadata(Value = "application/widget", IsBinary = true)]
        WGT,

        [MimeTypeMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WKS,

        [MimeTypeMetadata(Value = "video/x-ms-wm", IsBinary = true)]
        WM,

        [MimeTypeMetadata(Value = "audio/x-ms-wma", IsBinary = true)]
        WMA,

        [MimeTypeMetadata(Value = "application/x-ms-wmd", IsBinary = true)]
        WMD,

        [MimeTypeMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        WMF,

        [MimeTypeMetadata(Value = "text/vnd.wap.wml", IsText = true)]
        WML,

        [MimeTypeMetadata(Value = "application/vnd.wap.wmlc", IsBinary = true)]
        WMLC,

        [MimeTypeMetadata(Value = "text/vnd.wap.wmlscript", IsText = true)]
        WMLS,

        [MimeTypeMetadata(Value = "application/vnd.wap.wmlscriptc", IsBinary = true)]
        WMLSC,

        [MimeTypeMetadata(Value = "video/x-ms-wmv", IsBinary = true)]
        WMV,

        [MimeTypeMetadata(Value = "video/x-ms-wmx", IsBinary = true)]
        WMX,

        [MimeTypeMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        WMZ,

        [MimeTypeMetadata(Value = "application/font-woff", IsBinary = true)]
        WOFF,

        [MimeTypeMetadata(Value = "application/vnd.wordperfect", IsBinary = true)]
        WPD,

        [MimeTypeMetadata(Value = "application/vnd.ms-wpl", IsBinary = true)]
        WPL,

        [MimeTypeMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WPS,

        [MimeTypeMetadata(Value = "application/vnd.wqd", IsBinary = true)]
        WQD,

        [MimeTypeMetadata(Value = "application/x-mswrite", IsBinary = true)]
        WRI,

        [MimeTypeMetadata(Value = "model/vrml", IsBinary = true)]
        WRL,

        [MimeTypeMetadata(Value = "application/wsdl+xml", IsText = true)]
        WSDL,

        [MimeTypeMetadata(Value = "application/wspolicy+xml", IsText = true)]
        WSPOLICY,

        [MimeTypeMetadata(Value = "application/vnd.webturbo", IsBinary = true)]
        WTB,

        [MimeTypeMetadata(Value = "video/x-ms-wvx", IsBinary = true)]
        WVX,

        [MimeTypeMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        X32,

        [MimeTypeMetadata(Value = "model/x3d+xml", IsText = true)]
        X3D,

        [MimeTypeMetadata(Value = "model/x3d+binary", IsBinary = true)]
        X3DB,

        [MimeTypeMetadata(Value = "model/x3d+binary", IsBinary = true)]
        X3DBZ,

        [MimeTypeMetadata(Value = "model/x3d+vrml", IsBinary = true)]
        X3DV,

        [MimeTypeMetadata(Value = "model/x3d+vrml", IsBinary = true)]
        X3DVZ,

        [MimeTypeMetadata(Value = "model/x3d+xml", IsText = true)]
        X3DZ,

        [MimeTypeMetadata(Value = "application/xaml+xml", IsText = true)]
        XAML,

        [MimeTypeMetadata(Value = "application/x-silverlight-app", IsBinary = true)]
        XAP,

        [MimeTypeMetadata(Value = "application/vnd.xara", IsBinary = true)]
        XAR,

        [MimeTypeMetadata(Value = "application/x-ms-xbap", IsBinary = true)]
        XBAP,

        [MimeTypeMetadata(Value = "application/vnd.fujixerox.docuworks.binder", IsBinary = true)]
        XBD,

        [MimeTypeMetadata(Value = "image/x-xbitmap", IsBinary = true)]
        XBM,

        [MimeTypeMetadata(Value = "application/xcap-diff+xml", IsText = true)]
        XDF,

        [MimeTypeMetadata(Value = "application/vnd.syncml.dm+xml", IsText = true)]
        XDM,

        [MimeTypeMetadata(Value = "application/vnd.adobe.xdp+xml", IsText = true)]
        XDP,

        [MimeTypeMetadata(Value = "application/dssc+xml", IsText = true)]
        XDSSC,

        [MimeTypeMetadata(Value = "application/vnd.fujixerox.docuworks", IsBinary = true)]
        XDW,

        [MimeTypeMetadata(Value = "application/xenc+xml", IsText = true)]
        XENC,

        [MimeTypeMetadata(Value = "application/patch-ops-error+xml", IsText = true)]
        XER,

        [MimeTypeMetadata(Value = "application/vnd.adobe.xfdf", IsBinary = true)]
        XFDF,

        [MimeTypeMetadata(Value = "application/vnd.xfdl", IsBinary = true)]
        XFDL,

        [MimeTypeMetadata(Value = "application/xhtml+xml", IsText = true)]
        XHT,

        [MimeTypeMetadata(Value = "application/xhtml+xml", IsText = true)]
        XHTML,

        [MimeTypeMetadata(Value = "application/xv+xml", IsText = true)]
        XHVML,

        [MimeTypeMetadata(Value = "image/vnd.xiff", IsBinary = true)]
        XIF,

        [MimeTypeMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLA,

        [MimeTypeMetadata(Value = "application/vnd.ms-excel.addin.macroenabled.12", IsBinary = true)]
        XLAM,

        [MimeTypeMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLC,

        [MimeTypeMetadata(Value = "application/x-xliff+xml", IsText = true)]
        XLF,

        [MimeTypeMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLM,

        [MimeTypeMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLS,

        [MimeTypeMetadata(Value = "application/vnd.ms-excel.sheet.binary.macroenabled.12", IsBinary = true)]
        XLSB,

        [MimeTypeMetadata(Value = "application/vnd.ms-excel.sheet.macroenabled.12", IsBinary = true)]
        XLSM,

        [MimeTypeMetadata(Value = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", IsBinary = true)]
        XLSX,

        [MimeTypeMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLT,

        [MimeTypeMetadata(Value = "application/vnd.ms-excel.template.macroenabled.12", IsBinary = true)]
        XLTM,

        [MimeTypeMetadata(Value = "application/vnd.openxmlformats-officedocument.spreadsheetml.template", IsBinary = true)]
        XLTX,

        [MimeTypeMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLW,

        [MimeTypeMetadata(Value = "audio/xm", IsBinary = true)]
        XM,

        [MimeTypeMetadata(Value = "application/xml", IsText = true)]
        XML,

        [MimeTypeMetadata(Value = "application/vnd.olpc-sugar", IsBinary = true)]
        XO,

        [MimeTypeMetadata(Value = "application/xop+xml", IsText = true)]
        XOP,

        [MimeTypeMetadata(Value = "application/x-xpinstall", IsBinary = true)]
        XPI,

        [MimeTypeMetadata(Value = "application/xproc+xml", IsText = true)]
        XPL,

        [MimeTypeMetadata(Value = "image/x-xpixmap", IsBinary = true)]
        XPM,

        [MimeTypeMetadata(Value = "application/vnd.is-xpr", IsBinary = true)]
        XPR,

        [MimeTypeMetadata(Value = "application/vnd.ms-xpsdocument", IsBinary = true)]
        XPS,

        [MimeTypeMetadata(Value = "application/vnd.intercon.formnet", IsBinary = true)]
        XPW,

        [MimeTypeMetadata(Value = "application/vnd.intercon.formnet", IsBinary = true)]
        XPX,

        [MimeTypeMetadata(Value = "application/xml", IsText = true)]
        XSL,

        [MimeTypeMetadata(Value = "application/xslt+xml", IsText = true)]
        XSLT,

        [MimeTypeMetadata(Value = "application/vnd.syncml+xml", IsText = true)]
        XSM,

        [MimeTypeMetadata(Value = "application/xspf+xml", IsText = true)]
        XSPF,

        [MimeTypeMetadata(Value = "application/vnd.mozilla.xul+xml", IsText = true)]
        XUL,

        [MimeTypeMetadata(Value = "application/xv+xml", IsText = true)]
        XVM,

        [MimeTypeMetadata(Value = "application/xv+xml", IsText = true)]
        XVML,

        [MimeTypeMetadata(Value = "image/x-xwindowdump", IsBinary = true)]
        XWD,

        [MimeTypeMetadata(Value = "chemical/x-xyz", IsBinary = true)]
        XYZ,

        [MimeTypeMetadata(Value = "application/x-xz", IsBinary = true)]
        XZ,

        [MimeTypeMetadata(Value = "application/yang", IsBinary = true)]
        YANG,

        [MimeTypeMetadata(Value = "application/yin+xml", IsText = true)]
        YIN,

        [MimeTypeMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z1,

        [MimeTypeMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z2,

        [MimeTypeMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z3,

        [MimeTypeMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z4,

        [MimeTypeMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z5,

        [MimeTypeMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z6,

        [MimeTypeMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z7,

        [MimeTypeMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z8,

        [MimeTypeMetadata(Value = "application/vnd.zzazz.deck+xml", IsText = true)]
        ZAZ,

        [MimeTypeMetadata(Value = "application/zip", IsBinary = true)]
        ZIP,

        [MimeTypeMetadata(Value = "application/vnd.zul", IsBinary = true)]
        ZIR,

        [MimeTypeMetadata(Value = "application/vnd.zul", IsBinary = true)]
        ZIRZ,

        [MimeTypeMetadata(Value = "application/vnd.handheld-entertainment+xml", IsText = true)]
        ZMM,

        [MimeTypeMetadata(Value = "application/octet-stream", IsBinary = true)]
        DEFAULT
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    class MimeTypeMetadata : Attribute
    {
        public MimeTypeMetadata()
        {
            this.Value = "text/plain";
            this.IsText = true;
        }

        public string Value { get; set; }
        public bool IsText { get; set; }
        public bool IsBinary
        {
            get
            {
                return !this.IsText;
            }
            set
            {
                this.IsText = !value;
            }
        }
    }


    public static class ContentTypeExtensions
    {
        public static string ToValue(this MimeTypes ct)
        {
            var MimeTypeMetadata = ct.GetCustomAttribute<MimeTypeMetadata>();
            return (MimeTypeMetadata != null) ? ((MimeTypeMetadata)MimeTypeMetadata).Value : ct.ToString();
        }
        public static string ToValueCategory(this MimeTypes ct)
        {
            var value = ct.ToValue();
            var splitterIndex = value.IndexOf("/");
            return value.Substring(0, splitterIndex);
        }

        public static bool IsText(this MimeTypes ct)
        {
            var MimeTypeMetadata = ct.GetCustomAttribute<MimeTypeMetadata>();
            return (MimeTypeMetadata != null) ? ((MimeTypeMetadata)MimeTypeMetadata).IsText : true;
        }

        public static bool IsBinary(this MimeTypes ct)
        {
            var MimeTypeMetadata = ct.GetCustomAttribute<MimeTypeMetadata>();
            return (MimeTypeMetadata != null) ? ((MimeTypeMetadata)MimeTypeMetadata).IsBinary : false;
        }
    }

}
