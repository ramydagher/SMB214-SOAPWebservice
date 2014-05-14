
package soapjavaclient;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.Action;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebService(name = "WeightConvert", targetNamespace = "http://ws/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface WeightConvert {


    /**
     * 
     * @param kg
     * @return
     *     returns double
     */
    @WebMethod(operationName = "KgToPound")
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "KgToPound", targetNamespace = "http://ws/", className = "soapjavaclient.KgToPound")
    @ResponseWrapper(localName = "KgToPoundResponse", targetNamespace = "http://ws/", className = "soapjavaclient.KgToPoundResponse")
    @Action(input = "http://ws/WeightConvert/KgToPoundRequest", output = "http://ws/WeightConvert/KgToPoundResponse")
    public double kgToPound(
        @WebParam(name = "Kg", targetNamespace = "")
        double kg);

    /**
     * 
     * @param pound
     * @return
     *     returns double
     */
    @WebMethod(operationName = "PoundToKg")
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "PoundToKg", targetNamespace = "http://ws/", className = "soapjavaclient.PoundToKg")
    @ResponseWrapper(localName = "PoundToKgResponse", targetNamespace = "http://ws/", className = "soapjavaclient.PoundToKgResponse")
    @Action(input = "http://ws/WeightConvert/PoundToKgRequest", output = "http://ws/WeightConvert/PoundToKgResponse")
    public double poundToKg(
        @WebParam(name = "Pound", targetNamespace = "")
        double pound);

}
