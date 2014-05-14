
package soapjavaclient;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for PoundToKg complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="PoundToKg">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="Pound" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "PoundToKg", propOrder = {
    "pound"
})
public class PoundToKg {

    @XmlElement(name = "Pound")
    protected double pound;

    /**
     * Gets the value of the pound property.
     * 
     */
    public double getPound() {
        return pound;
    }

    /**
     * Sets the value of the pound property.
     * 
     */
    public void setPound(double value) {
        this.pound = value;
    }

}
