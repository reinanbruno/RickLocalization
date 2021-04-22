import { Dimension } from "./dimension";

export interface DetailsRick {
  id: string;
  name: string;
  urlImage: string;
  description: string;
  dimensionOrigin: Dimension;
  dimensionCurrent: Dimension;
}
