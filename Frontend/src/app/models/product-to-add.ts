export class ProductToAdd {
    constructor(
        public name: string,
        public categoryId: number,
        public price: number,
        public colors: { colour_name: string, hex_value: string }[],
        public numOfProductInStock: number,
        public image_link:string,
        public description:string,
        public brandsid: number,
       
        
    ) {}
}
