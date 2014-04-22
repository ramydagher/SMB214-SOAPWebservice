/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package ws;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author dev
 */
@WebService(serviceName = "WeightConvert")
public class WeightConvert {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "KgToPound")
    public double KgToPound(@WebParam(name = "Kg") double KG) {
        return KG * 2.20462;
    }
    
    @WebMethod(operationName = "PoundToKg")
    public double PoundToKg(@WebParam(name = "Pound") double Pound) {
        return Pound / 2.20462;
    }
}
