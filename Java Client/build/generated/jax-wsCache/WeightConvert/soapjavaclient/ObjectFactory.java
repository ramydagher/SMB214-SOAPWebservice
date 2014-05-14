
package soapjavaclient;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the soapjavaclient package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _KgToPoundResponse_QNAME = new QName("http://ws/", "KgToPoundResponse");
    private final static QName _KgToPound_QNAME = new QName("http://ws/", "KgToPound");
    private final static QName _PoundToKg_QNAME = new QName("http://ws/", "PoundToKg");
    private final static QName _PoundToKgResponse_QNAME = new QName("http://ws/", "PoundToKgResponse");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: soapjavaclient
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link PoundToKg }
     * 
     */
    public PoundToKg createPoundToKg() {
        return new PoundToKg();
    }

    /**
     * Create an instance of {@link KgToPound }
     * 
     */
    public KgToPound createKgToPound() {
        return new KgToPound();
    }

    /**
     * Create an instance of {@link PoundToKgResponse }
     * 
     */
    public PoundToKgResponse createPoundToKgResponse() {
        return new PoundToKgResponse();
    }

    /**
     * Create an instance of {@link KgToPoundResponse }
     * 
     */
    public KgToPoundResponse createKgToPoundResponse() {
        return new KgToPoundResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link KgToPoundResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "KgToPoundResponse")
    public JAXBElement<KgToPoundResponse> createKgToPoundResponse(KgToPoundResponse value) {
        return new JAXBElement<KgToPoundResponse>(_KgToPoundResponse_QNAME, KgToPoundResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link KgToPound }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "KgToPound")
    public JAXBElement<KgToPound> createKgToPound(KgToPound value) {
        return new JAXBElement<KgToPound>(_KgToPound_QNAME, KgToPound.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link PoundToKg }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "PoundToKg")
    public JAXBElement<PoundToKg> createPoundToKg(PoundToKg value) {
        return new JAXBElement<PoundToKg>(_PoundToKg_QNAME, PoundToKg.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link PoundToKgResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://ws/", name = "PoundToKgResponse")
    public JAXBElement<PoundToKgResponse> createPoundToKgResponse(PoundToKgResponse value) {
        return new JAXBElement<PoundToKgResponse>(_PoundToKgResponse_QNAME, PoundToKgResponse.class, null, value);
    }

}
